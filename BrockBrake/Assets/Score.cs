using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    static public int score = 0;    //score‚Ì‰Šú‰»

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (1 <= score){

            SceneManager.LoadScene("Result");
        }
    }
}