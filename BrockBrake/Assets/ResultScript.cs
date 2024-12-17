using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultScript : MonoBehaviour
{
    public TextMeshProUGUI timeText; // 経過時間を表示するTextコンポーネント

    void Start()
    {
        // 保存された時間を解析
        string[] timeParts = TimerScript.timeString.Split(':'); 
        int minutes = int.Parse(timeParts[0]); 
        int seconds = int.Parse(timeParts[1]); 
        
        // 合計秒数を計算
        int totalSeconds = minutes * 60 + seconds; 
        
        // 表示メッセージを決定
        string resultMessage; 
        if (totalSeconds < 20) { 
            resultMessage = "Nice!";
        } else if(totalSeconds < 60) { 
            resultMessage = "Great!";
        }else{
            resultMessage = "Excellent!";
        }

        timeText.text = "Time:" + TimerScript.timeString + "\n" + "\n" + resultMessage; ; // 保存された時間を表示
    }
}
