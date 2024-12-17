using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;  // 敵オブジェクトの配列
    public Text gameOverText;     // Game Overテキスト
    public Button endButton;      // ゲーム終了ボタン
    public Button retryButton;    // リトライボタン

    void Start()
    {
        // 初期状態ではUIを非表示にする
        gameOverText.gameObject.SetActive(false);
        endButton.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);

        // ボタンにリスナーを追加
        endButton.onClick.AddListener(EndGame);
        retryButton.onClick.AddListener(RetryGame);
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            // 敵が全て消えたらGame Over UIを表示する
            gameOverText.gameObject.SetActive(true);
            endButton.gameObject.SetActive(true);
            retryButton.gameObject.SetActive(true);
        }
    }

    void EndGame()
    {
        // ゲームを終了する処理
        Application.Quit();
    }

    void RetryGame()
    {
        // シーンをリロードする処理
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
