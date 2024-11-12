-- 電商，設計Postgresql SQL table:
-- - 商品(product)
-- - 商品的規格(product_sku), 詳細規格的 spec 使用 JSONB 儲存，如: {"memory": "256GB"}，需記錄庫存量與安全水位量。
-- - 商品分類(product_category) 有name_path(LTREE,pkey)，一個商品支援多種分類方式 。
-- pkey id 預設都用 uuid, user_entity id 預設都用 varchar(36), 時間欄位預設都用 timestamptz
-- Enable required extensions
CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE EXTENSION IF NOT EXISTS "ltree";

-- 用戶 (User)
CREATE TABLE "auth"."user_entity" (
	id varchar(36) NOT NULL,
	email varchar(255) NULL,
	email_constraint varchar(255) NULL,
	email_verified bool DEFAULT false NOT NULL,
	enabled bool DEFAULT false NOT NULL,
	federation_link varchar(255) NULL,
	first_name varchar(255) NULL,
	last_name varchar(255) NULL,
	realm_id varchar(255) NULL,
	username varchar(255) NULL,
	created_timestamp int8 NULL,
	service_account_client_link varchar(255) NULL,
	not_before int4 DEFAULT 0 NOT NULL,
	CONSTRAINT constraint_fb PRIMARY KEY (id),
	CONSTRAINT uk_dykn684sl8up1crfei6eckhd7 UNIQUE (realm_id, email_constraint),
	CONSTRAINT uk_ru8tt6t700s9v50bu18ws5ha6 UNIQUE (realm_id, username)
);
CREATE INDEX "auth"."idx_user_email" ON "auth"."user_entity" USING btree (email);

-- 商品分類 (Product Category)
CREATE TABLE "product"."product_category" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    name_path LTREE UNIQUE NOT NULL, -- 樹狀結構儲存分類層級
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- 商品 (Product)
CREATE TABLE "product"."product" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    name VARCHAR(255) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW(),
    snapshot_version TIMESTAMPTZ DEFAULT NOW()
);

-- 商品 SKU (Product SKU)
CREATE TABLE "product"."product_sku" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    product_id UUID REFERENCES "product"."product" (id) ON DELETE CASCADE, -- 儲存詳細規格
    spec JSONB NOT NULL, -- 庫存量
    stock_quantity INT DEFAULT 0, -- 安全水位量
    safety_stock INT DEFAULT 0,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW(),
    snapshot_version TIMESTAMPTZ DEFAULT NOW()
);

-- 商品與分類的多對多關聯 (Product-Category Mapping)
CREATE TABLE "product"."product_category_map" (
    product_id UUID REFERENCES "product"."product" (id) ON DELETE CASCADE,
    category_id UUID REFERENCES "product"."product_category" (id) ON DELETE CASCADE,
    PRIMARY KEY (product_id, category_id)
);

-- 訂單表 (Order)
CREATE TABLE "order"."order" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
	transaction_no varchar(20) UNIQUE NOT NULL,
    customer_name VARCHAR(255) NOT NULL,
    total_amount DECIMAL(10, 2) NOT NULL, -- 訂單狀態：pending, completed, cancelled
    delivery_fee DECIMAL(10, 2) NOT NULL, -- 運費 
    status VARCHAR(50) DEFAULT 'pending',
	user_id varchar(36) NOT NULL REFERENCES "auth"."user_entity" (id) ON DELETE CASCADE, -- 下單的人
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- 訂單項目表 (Order Item)
CREATE TABLE "order"."order_item" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    order_id UUID REFERENCES "order"."order" (id) ON DELETE CASCADE,
    product_id UUID REFERENCES "product"."product" (id) ON DELETE CASCADE,
    product_sku_id UUID REFERENCES "product"."product_sku" (id) ON DELETE CASCADE,
    snapshot_version TIMESTAMPTZ DEFAULT NOW(),
    quantity INT DEFAULT 1, -- 購買數量
    price DECIMAL(10, 2) NOT NULL, -- 商品單價
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);


-- 訂單狀態歷史表 (Order Status)
CREATE TABLE "order"."order_status_history" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),
    order_id UUID REFERENCES "order"."order" (id) ON DELETE CASCADE,
    from_status VARCHAR(50),
    to_status VARCHAR(50) NOT NULL,
    reason VARCHAR(50) , -- 原因，如出貨、確認、取消
    reason_data JSONB,   -- 相關資料
    creater_id varchar(36) NOT NULL,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- 實作簡述：
-- user_id 於訂單表：在 order 表中新增 user_id 欄位，並設置為外鍵參照 user_entity 表中的 id。這樣每次建立訂單時，會紀錄該訂單所屬的購買者。

-- 快照表 snapshot_product 與 snapshot_product_sku：

-- 當訂單成立時，會將對應的商品和 SKU 資料（包括價格、庫存等）複製並儲存到 snapshot_product 和 snapshot_product_sku 表中，並使用 (id, snapshot_version) 來確保每個版本的商品和 SKU 唯一。
-- snapshot_product 用來儲存商品的快照資訊，snapshot_product_sku 則儲存該商品的 SKU 資訊。
-- 訂單項目表 order_item 增加快照版本：每個訂單項目會指向當時商品及其 SKU 的快照版本，這樣在查看訂單時，可以知道當時訂購的是哪個版本的商品和 SKU。

-- 這樣的設計能夠確保商品和 SKU 的歷史資料在訂單中保持一致，並且避免資料衝突。

-- 商品快照表 (Snapshot Product)
CREATE TABLE "order"."snapshot_product" (
    id UUID NOT NULL,  -- 商品 ID
    snapshot_version TIMESTAMPTZ NOT NULL DEFAULT NOW(),  -- 快照版本
    name VARCHAR(255) NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW(),
    PRIMARY KEY (id, snapshot_version)  -- 確保每個商品的不同版本唯一
);

-- 商品 SKU 快照表 (Snapshot Product SKU)
CREATE TABLE "order"."snapshot_product_sku" (
    id UUID NOT NULL,  -- SKU ID
    product_id UUID,  -- 關聯商品快照
    spec JSONB NOT NULL,  -- 庫存量等詳細規格
    stock_quantity INT DEFAULT 0,  -- 庫存量
    safety_stock INT DEFAULT 0,  -- 安全庫存量
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW(),
    snapshot_version TIMESTAMPTZ NOT NULL DEFAULT NOW(),  -- 快照版本
    PRIMARY KEY (id, snapshot_version)  -- 確保每個 SKU 的不同版本唯一
);

-- 物流單表 (Shipment)
CREATE TABLE "shipment"."shipment" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),  -- 物流單 ID
    tracking_number VARCHAR(255) UNIQUE NOT NULL,  -- 物流單號
    status VARCHAR(50) DEFAULT 'pending',  -- 物流單狀態，例如 pending, shipped, delivered, returned
    carrier_name VARCHAR(50), -- 物流服務商名稱
    carrier_service_type VARCHAR(50), -- 服務類型 宅配, 到店, 超取
    temperature_zone VARCHAR(50), -- 溫層 低溫，長溫
    sender_name VARCHAR(100),    -- 寄件人姓名
    sender_phone VARCHAR(100),   -- 寄件人電話
    receiver_name VARCHAR(100),  -- 收件人姓名
    receiver_phone VARCHAR(100), -- 收件人電話
    receiver_address VARCHAR(255), -- 收件人地址
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- 物流箱表 (Cargo)
CREATE TABLE "shipment"."cargo" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),  -- 物流箱 ID
    shipment_id UUID REFERENCES "shipment"."shipment" (id) ON DELETE CASCADE,  -- 物流單 ID
    tracking_number VARCHAR(255),                    -- 箱子編號
    length DECIMAL(10, 2),
    width DECIMAL(10, 2),
    height DECIMAL(10, 2),
    weight DECIMAL(10, 2),
    volume DECIMAL(10, 2) GENERATED ALWAYS AS (length * width * height) STORED,
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- 物流箱與商品 SKU 的多對多關聯表和商品數量
CREATE TABLE "shipment"."cargo_product_sku_quantity_map" (
    cargo_id UUID REFERENCES "shipment"."cargo" (id) ON DELETE CASCADE,  -- 訂單 ID
    product_sku_id UUID REFERENCES "product"."product_sku" (id) ON DELETE NO ACTION,  -- 商品 Sku ID
    quantity INT DEFAULT 1 -- 數量
);

-- 訂單與物流單的多對多關聯表 (Order-Shipment Mapping)
CREATE TABLE "order"."order_shipment_map" (
    order_id UUID REFERENCES "order"."order" (id) ON DELETE CASCADE,  -- 訂單 ID
    shipment_id UUID REFERENCES "shipment"."shipment" (id) ON DELETE CASCADE,  -- 物流單 ID
    flow_type VARCHAR(50) NOT NULL CHECK (flow_type IN ('forward', 'reverse')),  -- 流向類型，正向（forward）或逆向（reverse）
    PRIMARY KEY (order_id, shipment_id, flow_type),  -- 確保每筆訂單-物流的流向唯一
    created_at TIMESTAMPTZ DEFAULT NOW()
);

-- 支付單表 (Payment)
CREATE TABLE "payment"."payment" (
    id UUID PRIMARY KEY DEFAULT uuid_generate_v4(),  -- 支付單 ID
    payment_number VARCHAR(255) UNIQUE NOT NULL,     -- 支付單號
    amount DECIMAL(10, 2) NOT NULL,  -- 支付總金額
    status VARCHAR(50) DEFAULT 'pending',  -- 支付狀態，例如 pending, completed, failed, refunded
    payment_method VARCHAR(50) NOT NULL,  -- 支付方式，例如 credit_card, bank_transfer
    payment_provider VARCHAR(50) NOT NULL,  -- 支付服務提供方，例如 paypal, ecpay, stripe
    return_url VARCHAR(255) NOT NULL,     -- 訂單結果後端 Server URL
    order_result_url VARCHAR(255) NOT NULL, -- 訂單結果前端 URL
    check_mac_value VARCHAR(255) NOT NULL, -- 檢查 MAC 值
    created_at TIMESTAMPTZ DEFAULT NOW(),
    updated_at TIMESTAMPTZ DEFAULT NOW()
);

-- 訂單與支付單的多對多關聯表 (Order-Payment Mapping)
CREATE TABLE "order"."order_payment_map" (
    order_id UUID REFERENCES "order"."order" (id) ON DELETE CASCADE,  -- 訂單 ID
    payment_id UUID REFERENCES "payment"."payment" (id) ON DELETE CASCADE,  -- 支付單 ID
    PRIMARY KEY (order_id, payment_id),  -- 確保每個訂單與支付單的唯一關聯
    created_at TIMESTAMPTZ DEFAULT NOW()
);