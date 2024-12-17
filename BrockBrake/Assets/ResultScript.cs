using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultScript : MonoBehaviour
{
    public TextMeshProUGUI timeText; // �o�ߎ��Ԃ�\������Text�R���|�[�l���g

    void Start()
    {
        // �ۑ����ꂽ���Ԃ����
        string[] timeParts = TimerScript.timeString.Split(':'); 
        int minutes = int.Parse(timeParts[0]); 
        int seconds = int.Parse(timeParts[1]); 
        
        // ���v�b�����v�Z
        int totalSeconds = minutes * 60 + seconds; 
        
        // �\�����b�Z�[�W������
        string resultMessage; 
        if (totalSeconds < 20) { 
            resultMessage = "Nice!";
        } else if(totalSeconds < 60) { 
            resultMessage = "Great!";
        }else{
            resultMessage = "Excellent!";
        }

        timeText.text = "Time:" + TimerScript.timeString + "\n" + "\n" + resultMessage; ; // �ۑ����ꂽ���Ԃ�\��
    }
}
