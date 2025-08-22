# Blazor について　※AI等を使用。調査内容のメモです
Blazor WebAssemblyは、C#でWebアプリを作れる技術で、.NET 8
## ソリューションの構成
- プロジェクト
  - WebAssemblyBlazorApp1
    - Webアプリ本体。ページやレイアウト、サービスワーカーなどが含まれます
    - | ファイル名 | 役割・説明 | |------------|------------|
    - | PortfolioWebAssemblyBlazorApp1.csproj | プロジェクトの設定ファイル。ターゲットフレームワークや使うパッケージが記載されています。 |
    - | App.razor | アプリ全体のルーティング（ページの切り替え）を管理します。 |
    - | Program.cs | アプリの起動時の設定やサービスの登録を行います。 |
    - | _Imports.razor | Razorファイルでよく使う名前空間をまとめてインポートします。 |
    - | Pages/About.razor | 「About（このアプリについて）」ページの内容を記述します。 |
    - | Layout/NavMenu.razor | サイドメニュー（ナビゲーションメニュー）のレイアウトを定義します。 |
    - | wwwroot/service-worker.js | オフライン対応のためのサービスワーカーのスクリプトです。 |
    - | wwwroot/service-worker.published.js | 公開用のサービスワーカーです。 |
  - WebAssemblyBlazorApp1.AppHost
    - ホスト（サーバー側）プロジェクトです。
      ※Blazor WebAssemblyは基本的にクライアント側ですが、AppHostは公開やデバッグ時に使われることがあります。
    - | ファイル名 | 役割・説明 | |------------|------------|
    - | Program.cs | サーバー側の起動処理や設定を記述します。 |
  - WebAssemblyBlazorApp1.ServiceDefaults
    -- 目的: サービスの共通設定や拡張機能をまとめるプロジェクト
    -- | ファイル名 | 役割・説明 | |------------|------------|
    -- | Extensions.cs | サービスの拡張メソッドなど、共通処理を記述します。 |
  
