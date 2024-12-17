using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bar : MonoBehaviour
{
    int accel;
    // Use this for initialization
    void Start()
    {
        accel = 500;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);

    }
}