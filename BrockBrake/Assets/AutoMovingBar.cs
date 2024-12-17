using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovingBar : MonoBehaviour
{
    public float speed = 5.0f;  // �o�[�̈ړ����x
    private Vector3 direction = Vector3.right;  // �����̈ړ�����

    // Update is called once per frame
    void Update()
    {
        // �o�[�����݂̕����Ɉړ�������
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // �ǂɂԂ�������������t�ɂ���
        if (collision.gameObject.tag == "Wall")
        {
            direction = -direction;
        }
    }
}
