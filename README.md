# Hoton 多租戶電商平台

**打造一站式電商解決方案**  
本平台專為多租戶設計，支持租戶在單一平台內同時運營 **品牌電商**、**一頁式商店**、**團購網** 與 **直播電商**，滿足不同業務模式與市場需求的靈活整合。

- 🎯 **多元商業模式**：從品牌形象打造到快速轉化的一頁式商店，還有高互動性的直播購物和高效團購，助您全面覆蓋各類目標客群。
- 🏗️ **彈性多租戶架構**：每個租戶可自由定制功能模組與介面，實現個性化運營。
- 🌐 **無縫擴展**：支持多語言、多貨幣，幫助您輕鬆拓展海外市場。

## 功能特色

1. **品牌電商**

   - 提供完整的購物車、會員系統與高級商品展示功能，支持 SEO 優化，提升品牌曝光與銷售轉化。

2. **一頁式商店**

   - 為單品促銷活動設計的一頁式購物體驗，極簡快速，提高消費者轉化率。

3. **團購網**

   - 支持靈活的團購規則設置，助力營銷活動快速聚焦流量，實現銷售增長。

4. **直播電商**

   - 整合直播工具與即時購物功能，帶來更高的互動性與轉化效果，打造沉浸式購物體驗。

5. **多渠道銷售整合**

   - 支持同步至第三方平台如 Amazon、eBay、Shopee 等，實現全渠道銷售。
   - 集成社交媒體購物功能（如 Instagram 購物標籤），直接在社群平台完成交易。

6. **自訂化網站設計**

   - 提供拖放式頁面編輯器與多樣化模板，讓租戶快速打造專屬品牌形象的網站。
   - 支持進階 CSS/HTML 編輯，滿足高階用戶需求。

7. **會員忠誠度與行銷自動化**

   - 提供積分、優惠券、會員等級等功能，激勵重複購買。
   - 支持 EDM 電子郵件行銷、自動推播通知與個性化推薦，提升行銷效率與用戶黏性。

8. **全方位支付與物流、發票支持**

   - 集成多種支付方式（信用卡、Apple Pay、Google Pay、Line Pay、綠界等）。
   - 支持與物流服務提供商（如 黑貓、超商取貨、本地快遞、綠界）的 API 整合，自動生成運單與配送追蹤。

9. **社群互動功能**

   - 提供商品評論、評分、問答與社群互動功能，提升社交影響力與消費者信任感。
   - 支持內建論壇或社群功能，增強租戶與用戶之間的黏性。

<!-- 12. 虛擬與實體混合銷售
支持虛擬商品（如課程、服務、數位產品）與實體商品的銷售，擴展商業模式。
提供電子憑證生成與自動發送功能。 -->

## 技術架構

- **後端**：採用 .Net8, PostgreSQL, RabbitMQ, [Hasura](https://hasura.io/docs/3.0/index)(GraphQL), [Keycloak](https://hasura.io/docs/3.0/index)(IAM)，支持高效的 API 調用與數據處理。
- **前端**：使用 [Tamagui](https://tamagui.dev/)(Nextjs, React Native) 實現模組化設計與 Web, 手機 App 共用 UI，提升可擴展性與維護性。
- **部署**：支持 Docker 容器化部署，結合 CI/CD 管線實現高效持續交付。

---

如果需要針對特定技術實現做補充，或是加入更詳細的操作說明，可以再展開細節！ 😊

## Database

```sh
# directly change tables to local database and then run this:
# check dotnet ef --version should be 8.x
dotnet ef dbcontext scaffold "Host=localhost;Port=5433;Database=hoton-dev;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL --force -o Entities/generated --context DomainDbContext
# generate migrations
dotnet ef migrations add <MigrationName>
```
