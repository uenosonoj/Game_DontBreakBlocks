using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovingBar : MonoBehaviour
{
    public float speed = 5.0f;  // バーの移動速度
    private Vector3 direction = Vector3.right;  // 初期の移動方向

    // Update is called once per frame
    void Update()
    {
        // バーを現在の方向に移動させる
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // 壁にぶつかったら方向を逆にする
        if (collision.gameObject.tag == "Wall")
        {
            direction = -direction;
        }
    }
}
