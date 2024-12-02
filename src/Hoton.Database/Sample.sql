-- 插入商品資料
INSERT INTO "product"."product" (id, realm_id, name, description, price, tags, temperature_zones, search_vector) VALUES
(uuid_generate_v4(), '8e98626a-3804-4ade-a812-566918b8a8dc', 'Laptop', 'A high-performance laptop suitable for work and gaming.', 1200.00, '["electronics", "laptop", "portable"]', '["ambient"]', to_tsvector('Laptop High Performance')),
(uuid_generate_v4(), '8e98626a-3804-4ade-a812-566918b8a8dc', 'Smartphone', 'A latest-gen smartphone with advanced camera capabilities.', 800.00, '["electronics", "smartphone", "mobile"]', '["ambient"]', to_tsvector('Smartphone Latest Gen')),
(uuid_generate_v4(), '8e98626a-3804-4ade-a812-566918b8a8dc', 'Wireless Earbuds', 'Compact and ergonomic earbuds with noise cancellation.', 150.00, '["electronics", "audio", "portable"]', '["ambient"]', to_tsvector('Wireless Earbuds Noise Cancellation')),
(uuid_generate_v4(), '8e98626a-3804-4ade-a812-566918b8a8dc', '4K Monitor', 'Ultra HD monitor for gaming and professional use.', 400.00, '["electronics", "monitor", "4K"]', '["ambient"]', to_tsvector('4K Monitor UHD')),
(uuid_generate_v4(), '8e98626a-3804-4ade-a812-566918b8a8dc', 'Gaming Keyboard', 'RGB mechanical keyboard with customizable macros.', 100.00, '["electronics", "keyboard", "gaming"]', '["ambient"]', to_tsvector('Gaming Keyboard RGB'));

-- 插入商品分類
INSERT INTO "product"."product_category" (product_id, category) VALUES
((SELECT id FROM "product"."product" WHERE name = 'Laptop'), 'electronics.laptop'),
((SELECT id FROM "product"."product" WHERE name = 'Smartphone'), 'electronics.smartphone'),
((SELECT id FROM "product"."product" WHERE name = 'Wireless Earbuds'), 'electronics.audio.wireless'),
((SELECT id FROM "product"."product" WHERE name = '4K Monitor'), 'electronics.monitor'),
((SELECT id FROM "product"."product" WHERE name = 'Gaming Keyboard'), 'electronics.keyboard.gaming');

-- 插入商品 SKU
INSERT INTO "product"."product_sku" (id, product_id, stock_quantity, safety_stock) VALUES
(uuid_generate_v4(), (SELECT id FROM "product"."product" WHERE name = 'Laptop'), 50, 10),
(uuid_generate_v4(), (SELECT id FROM "product"."product" WHERE name = 'Smartphone'), 100, 20),
(uuid_generate_v4(), (SELECT id FROM "product"."product" WHERE name = 'Wireless Earbuds'), 200, 30),
(uuid_generate_v4(), (SELECT id FROM "product"."product" WHERE name = '4K Monitor'), 70, 10),
(uuid_generate_v4(), (SELECT id FROM "product"."product" WHERE name = 'Gaming Keyboard'), 150, 25);

-- 插入商品 SKU 規格
INSERT INTO "product"."product_sku_spec" (id, product_sku_id, spec_name, spec_value) VALUES
(uuid_generate_v4(), (SELECT id FROM "product"."product_sku" WHERE product_id = (SELECT id FROM "product"."product" WHERE name = 'Laptop')), 'Color', 'Silver'),
(uuid_generate_v4(), (SELECT id FROM "product"."product_sku" WHERE product_id = (SELECT id FROM "product"."product" WHERE name = 'Smartphone')), 'Storage', '128GB'),
(uuid_generate_v4(), (SELECT id FROM "product"."product_sku" WHERE product_id = (SELECT id FROM "product"."product" WHERE name = 'Wireless Earbuds')), 'Color', 'Black'),
(uuid_generate_v4(), (SELECT id FROM "product"."product_sku" WHERE product_id = (SELECT id FROM "product"."product" WHERE name = '4K Monitor')), 'Size', '27 inch'),
(uuid_generate_v4(), (SELECT id FROM "product"."product_sku" WHERE product_id = (SELECT id FROM "product"."product" WHERE name = 'Gaming Keyboard')), 'Switch Type', 'Mechanical');
