using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject prefabBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            // 離されたマウスの場所へレイ（光線）を飛ばす
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ベクトルを取得（ワールド座標）
            var dir = ray.direction;

            //// 重力をかける
            //prefabBullet.GetComponent<Rigidbody>().isKinematic = false;     // falseで重力がかかる
            
            // プレハブの生成
            var bullet = Instantiate(prefabBullet);

            bullet.transform.position = transform.position;         // スクリプトを実行しているオブジェクト（カメラオブジェクト）の位置と同じ値にする

            // 発射
            bullet.GetComponent<BulletController>().Shoot(dir.normalized * 3000);
        }
    }
}
