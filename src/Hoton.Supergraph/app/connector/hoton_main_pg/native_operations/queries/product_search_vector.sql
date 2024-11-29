SELECT *
FROM "product"."product"
WHERE search_vector @@ plainto_tsquery({{keyword}})