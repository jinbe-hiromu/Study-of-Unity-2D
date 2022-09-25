# Study-of-Unity-2D

# Gitでの管理方法
1.Unityの設定
Edit > Project Settings > Editor で以下の設定をする
Version Control: Visible Meta Files
Asset Serialization:Force Text

metaファイル…Assetフォルダ内の全アセットに対してUnityで必要な管理情報が記述されるファイル．これを見れるようにする
Force Text…アセットをテキスト形式に変換．バージョン管理しやすくなる．

2.Git ignore
https://github.com/github/gitignore/blob/main/Unity.gitignore

3.Git Push
VSCodeでGitPushする

# トラブルシューティング
## スクリプトをVisualStudioで開こうとするとサポート外といわれる
[現象]
スクリプトをVisualStudioで開こうとするとサポート外といわれる

[原因]
VisualStudioでUnityのツールがインストールされていない

[解決策]
VisualStudioInstallerでUnityのツールをインストールする