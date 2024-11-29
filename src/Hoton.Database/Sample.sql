-- Sample data for product table
INSERT INTO "product"."product" (id, realm_id, name, description, price, tags, temperature_zones, search_vector)
VALUES 
('10cd8ebb-efda-4c9d-a20d-cf5c3f287d56', '8e98626a-3804-4ade-a812-566918b8a8dc', 'Smartphone XYZ', 'Latest model with advanced features', 699.99, '["electronics", "smartphone"]', '["ambient"]', to_tsvector('Smartphone XYZ')),
('08052e12-5892-4936-83f1-a65e9253e331', '8e98626a-3804-4ade-a812-566918b8a8dc', 'Laptop ABC', 'High-performance laptop for professionals', 1299.99, '["electronics", "laptop"]', '["ambient"]', to_tsvector('Laptop ABC')),
('fd7baa20-f0d8-4671-8d23-24d173f17b97', '8e98626a-3804-4ade-a812-566918b8a8dc', 'Wireless Earbuds', 'Noise-cancelling wireless earbuds', 199.99, '["electronics", "audio"]', '["ambient"]', to_tsvector('Wireless Earbuds')),
('87486196-e522-4bbd-9968-a004669ae4da', '8e98626a-3804-4ade-a812-566918b8a8dc', '【上野物產】便當小菜 玉米布丁酥 1包 共10個', '濃郁香甜雙重口感', 199.99, '["小菜"]', '["ambient"]', to_tsvector('【 上 野物 產 】 便當 小菜   玉米 布丁 酥   1 包   共 10 個'));

-- Sample data for product_category table
INSERT INTO "product"."product_category" (product_id, category, enabled)
VALUES 
('10cd8ebb-efda-4c9d-a20d-cf5c3f287d56', 'electronics.smartphones', TRUE),
('08052e12-5892-4936-83f1-a65e9253e331', 'electronics.laptops', TRUE),
('fd7baa20-f0d8-4671-8d23-24d173f17b97', 'electronics.audio', TRUE),
('87486196-e522-4bbd-9968-a004669ae4da', '生鮮.冷凍食品.烤物', TRUE);

-- Sample data for product_sku table
INSERT INTO "product"."product_sku" (id, product_id, spec, stock_quantity, safety_stock)
VALUES 
('27ef8c5e-cdbe-4d5d-a6b1-accffb0c7151', '10cd8ebb-efda-4c9d-a20d-cf5c3f287d56', '{"color": "black", "storage": "128GB", "RAM": "8GB"}', 100, 10),
('44ba180d-bcb1-43b2-96c6-0452b642721d', '08052e12-5892-4936-83f1-a65e9253e331', '{"color": "silver", "storage": "512GB", "RAM": "16GB"}', 50, 5),
('1f17ee1d-ea74-4391-bb64-1ece729a5837', 'fd7baa20-f0d8-4671-8d23-24d173f17b97', '{"color": "white", "battery_life": "24 hours"}', 200, 20),
('62b1983b-8411-4a7b-a603-5427b623006f', '87486196-e522-4bbd-9968-a004669ae4da', '{"color": "white", "重量": "0.5kg"}', 200, 20);