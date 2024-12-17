using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    //GUIで数字を変更できるようにするため,publicを使う
    public float speed;

    // Start関数は開始時に1度だけ呼び出される関数
    void Start()
    {
        //floatの場合は数字にfを追加する
        speed = 13.0f;
        GetComponent<Rigidbody>().AddForce((transform.right - transform.up) * speed,
            ForceMode.VelocityChange);
    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity =
        GetComponent<Rigidbody>().velocity.normalized * speed;
    }
}