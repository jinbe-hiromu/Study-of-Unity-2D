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

# ビルド方法
## スマートフォン用にビルドする
File>Build Setting
Platform選択後，SwitchPlatformを押す

![](./Picture/BuildSetting.png)

## Windows用にビルドする
File>Build Setting
でWindows/Mac/Linuxを選択

PlayerSettingで「Company Name」と「Product Name」を入力する．

![](./Picture/PlayerSetting.png)

ScenesInBuildにビルド対象のシーンをD＆Dでチェックを入れる．
BuildAndRunを実行．保存先は空フォルダでないとビルドエラーになる．

![](./Picture/ScenesInBuild.png)

# 背景色の設定方法
カメラを選択し，InspectorからBackgroundを変更

![](./Picture/BackgroundSetting.png)

# スクリプトの作成
プロジェクトウィンドウ「＋」ボタン＞C#Scriptを選択

![](./Picture/CreateCSharpScript1.png)

![](./Picture/CreateCSharpScript2.png)


# VisualStudio2022で編集
Edit>Preference>External Tools>External Script Editorで「VS2022」を選択

![](./Picture/ExternalTools.png)

# Component
## オブジェクト
### レイヤ
レイヤ番号が大きい順に画面の手前に表示される．

![](./Picture/OrderInLayer.png)

## AudioSourceの追加
オブジェクトをクリック＞AddComponentをクリック＞「AudioSouce」で検索し，追加する．

![](./Picture/AddAudioComponent.png)

音楽をAudioSourceにアタッチする．

![](./Picture/AttachAudioSource.png)

＊ゲーム開始時点で自動的に音が再生されないように，PlayOnAwakeのチェックを外す．

# Script
## アタッチ
C#Scriptをオブジェクトにアタッチさせる方法
アタッチしたいスクリプトをオブジェクトにD＆D

![](./Picture/ScriptAttach.png)

オブジェクトがアタッチされたかの確認方法
![](./Picture/AfterScriptAttach.png)

## デバッグ方法
「▶」を押下する．
停止するときは再度「▶」を押下する．

![](./Picture/DebugStart.png)

## フレームレート
どの性能のOSでも同じ速度で動かしたい場合

~~~C#
    void Start()
    {
        Application.targetFrameRate = 60;
    }
~~~

Q.なぜフレームレートを統一させるのか？
A.OSによってフレームレートが異なる．
スマートフォンの場合：60fps
高速なPCの場合：300fps
Update処理で右に1ずつ動かす処理を記入した場合，スマートフォンでは+60の位置，高速なPCでは+300の位置になり，OSによって移動量に差が発生してしまう．

## マウス
マウスが押されているかの判定．マウスがクリックされた瞬間に一度だけtrueを返す．
＊スマートフォンの場合はタッチに該当する

~~~C#
if (Input.GetMouseButtonDown(0)){   // 0:左クリック，1:右クリック，2:中クリック
  // 処理
}
~~~

マウスが離れた瞬間にtrueを返す

~~~C#
if (Input.GetMouseButtonUp(0)){   // 0:左クリック，1:右クリック，2:中クリック
  // 処理
}
~~~

マウスが押されている間ずっとtrueを返す．

~~~C#
if (Input.GetMouseButtonUp(0)){   // 0:左クリック，1:右クリック，2:中クリック
  // 処理
}
~~~

## キーボード
キーボードが押されているかの判定．
押されている場合はtrueを返す

GetKeyDown・・・押した瞬間にtrue

~~~C#
if(Input.GetKeyDown(KeyCode.LeftArrow)){
  // 処理
}
~~~

GetKey・・・押されている間にtrue

~~~C#
if(Input.GetKey(KeyCode.LeftArrow)){
  // 処理
}
~~~

GetKeyUp・・・離した瞬間にtrue

~~~C#
if(Input.GetKeyUp(KeyCode.LeftArrow)){
  // 処理
}
~~~

## 音の再生

~~~C#
GetComponent<AudioSource>().Play();
~~~

## オブジェクト
### 取得

~~~C#
var car = GameObject.Find("car");
~~~

### 削除
画面から消えた場合にオブジェクトを削除しないと，ずっと残り続けるので削除する．

~~~C#
if(transform.position.y < -5.0f){
  Destroy(gameObject);
}
~~~

### テキストに文字を表示

~~~C#
var distance = GameObject.Find("Distance");
distance.GetComponent<TextMeshProUGUI>().text = "入力する文字列";
~~~

(注意)TextMeshProでは標準で日本語を表示できない．日本語を表示するにはp.188を参照する．

### オブジェクトの座標を取得

~~~C#
var x = GameObject.Find("car").transform.position.x;
~~~

### 回転

~~~C#
transform.Rotate(0, 0, _rotationSpeed);   // 引数：X，Y，Z軸の回転スピード
~~~

### 移動

~~~C#
transform.Translate(speed, 0, 0);         // 引数：X，Y，Zの移動量
~~~

### 監督オブジェクト

CreateEmptyで追加した空のオブジェクトに監督スクリプトをアタッチする

# トラブルシューティング
## スクリプトをVisualStudioで開こうとするとサポート外といわれる
[現象]
スクリプトをVisualStudioで開こうとするとサポート外といわれる

[原因]
VisualStudioでUnityのツールがインストールされていない

[解決策]
VisualStudioInstallerでUnityのツールをインストールする