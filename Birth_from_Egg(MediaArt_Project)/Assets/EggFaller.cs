using System;
using System.Collections.Generic;
using UnityEngine;

public class EggFaller : MonoBehaviour
{
    //タマゴをゆっくりおろしていく
    //一定値に来たらxとzを所定の範囲にランダムに設置してリスポーンする
    public float xl = 0f, xh = 0f, zl = 0f, zh = 0f;
    public float respownY = 0f, warpPointY = 0f;

    private System.Random r;

    void Start()
    {
        r = new System.Random();//ランダムの生成
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y -= 0.0005f;//ゆっくり落ちていく

        if (pos.y < warpPointY)
        {//ワープポイントに来たらx,zを変えてリスポーンポイントにワープ
            pos.y = respownY;
            pos.x = (float)r.NextDouble() * (xh - xl) + xl;
            pos.z = (float)r.NextDouble() * (zh - zl) + zl;
        }

        transform.position = pos;


    }
}
