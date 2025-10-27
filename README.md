# poc-dotnet

このプロジェクトは、C#での基本的なHello Worldアプリケーションを示すテストプロジェクトです。

## プロジェクト構成

- `src/PocDotNet/Program.cs`: アプリケーションのエントリポイントで、"Hello, World!"をコンソールに出力します。
- `src/PocDotNet/PocDotNet.csproj`: プロジェクトの設定ファイルで、依存関係やターゲットフレームワークが定義されています。
- `tests/PocDotNet.Tests/UnitTest1.cs`: ユニットテストを含むテストクラスです。
- `tests/PocDotNet.Tests/PocDotNet.Tests.csproj`: テストプロジェクトの設定ファイルです。
- `poc-dotnet.sln`: ソリューションファイルで、プロジェクトとテストプロジェクトをまとめて管理します。
- `.gitignore`: Gitで無視するファイルやディレクトリを指定します。

## 必要な環境

- .NET SDK（推奨バージョン: .NET 6.0以上）

## 使用方法

### アプリケーションの実行

1. プロジェクトをクローンします：
   ```bash
   git clone <repository-url>
   cd poc-dotnet
   ```

2. アプリケーションをビルドして実行します：
   ```bash
   dotnet run --project src/PocDotNet
   ```

   または、ソリューションファイルを使用する場合：
   ```bash
   dotnet build poc-dotnet.sln
   dotnet run --project src/PocDotNet
   ```

### テストの実行

ユニットテストを実行するには：
```bash
dotnet test
```

### その他のコマンド

- プロジェクトをビルドのみ実行：
  ```bash
  dotnet build
  ```

- クリーンビルド：
  ```bash
  dotnet clean
  dotnet build
  ```

## 期待される出力

アプリケーションを正常に実行すると、コンソールに以下のメッセージが表示されます：
```
Hello, World!
```