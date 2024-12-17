using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; // TextMeshProの名前空間を追加

public class TimerScript : MonoBehaviour
{

    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    // 前のUpdateの時の秒数
    private float oldSeconds;
    // タイマー表示用テキスト
    private TextMeshProUGUI timerText; // TextMeshProUGUIに変更

    public static string timeString; // 時間を保存する静的変数

    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<TextMeshProUGUI>(); // TextMeshProUGUIを取得

    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        // 値が変わった時だけテキストUIを更新
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        timeString = minute.ToString("00") + ":" + ((int)seconds).ToString("00"); 
        timerText.text = timeString;

    }
}
