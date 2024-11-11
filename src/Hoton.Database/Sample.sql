-- 插入商品分類 (Product Category)
INSERT INTO product_category (name_path) 
VALUES 
    ('3C'), -- 顯示所有3C產品的根分類
    ('3C.手機'), -- 手機分類
    ('3C.筆記型電腦'), -- 筆記型電腦分類
    ('3C.耳機'); -- 耳機分類

-- 插入商品 (Product)
INSERT INTO product (name, description, price) 
VALUES 
    ('iPhone 15', '蘋果最新款iPhone 15，支援5G和A16處理器', 29999.99),
    ('MacBook Pro 16', '蘋果MacBook Pro 16英寸，搭載M1 Pro處理器', 54999.99),
    ('Sony WH-1000XM5', '索尼主動降噪耳機，支援藍牙連接', 11999.99);

-- 插入商品 SKU (Product SKU)
INSERT INTO product_sku (product_id, spec, stock_quantity, safety_stock) 
VALUES
    -- iPhone 15 256GB
    ((SELECT id FROM product WHERE name = 'iPhone 15'), '{"memory": "256GB", "color": "black"}', 50, 5),
    ((SELECT id FROM product WHERE name = 'iPhone 15'), '{"memory": "512GB", "color": "white"}', 30, 5),
    
    -- MacBook Pro 16 (M1 Pro, 16GB RAM, 512GB SSD)
    ((SELECT id FROM product WHERE name = 'MacBook Pro 16'), '{"processor": "M1 Pro", "ram": "16GB", "storage": "512GB SSD"}', 20, 2),
    ((SELECT id FROM product WHERE name = 'MacBook Pro 16'), '{"processor": "M1 Pro", "ram": "32GB", "storage": "1TB SSD"}', 10, 2),
    
    -- Sony WH-1000XM5
    ((SELECT id FROM product WHERE name = 'Sony WH-1000XM5'), '{"color": "black"}', 100, 10);
    
-- 插入商品與分類的關聯 (Product-Category Mapping)
INSERT INTO product_category_map (product_id, category_id)
SELECT p.id, c.id
FROM product p
JOIN product_category c ON c.name_path = CASE 
    WHEN p.name = 'iPhone 15' THEN '3C.手機'
    WHEN p.name = 'MacBook Pro 16' THEN '3C.筆記型電腦'
    WHEN p.name = 'Sony WH-1000XM5' THEN '3C.耳機'
    ELSE '3C'
END;
