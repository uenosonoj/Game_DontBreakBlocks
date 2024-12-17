using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; // TextMeshPro�̖��O��Ԃ�ǉ�

public class TimerScript : MonoBehaviour
{

    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    // �O��Update�̎��̕b��
    private float oldSeconds;
    // �^�C�}�[�\���p�e�L�X�g
    private TextMeshProUGUI timerText; // TextMeshProUGUI�ɕύX

    public static string timeString; // ���Ԃ�ۑ�����ÓI�ϐ�

    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<TextMeshProUGUI>(); // TextMeshProUGUI���擾

    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        // �l���ς�����������e�L�X�gUI���X�V
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
        timeString = minute.ToString("00") + ":" + ((int)seconds).ToString("00"); 
        timerText.text = timeString;

    }
}
