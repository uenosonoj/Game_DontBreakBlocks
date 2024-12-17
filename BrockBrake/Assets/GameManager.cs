using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;  // �G�I�u�W�F�N�g�̔z��
    public Text gameOverText;     // Game Over�e�L�X�g
    public Button endButton;      // �Q�[���I���{�^��
    public Button retryButton;    // ���g���C�{�^��

    void Start()
    {
        // ������Ԃł�UI���\���ɂ���
        gameOverText.gameObject.SetActive(false);
        endButton.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);

        // �{�^���Ƀ��X�i�[��ǉ�
        endButton.onClick.AddListener(EndGame);
        retryButton.onClick.AddListener(RetryGame);
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            // �G���S�ď�������Game Over UI��\������
            gameOverText.gameObject.SetActive(true);
            endButton.gameObject.SetActive(true);
            retryButton.gameObject.SetActive(true);
        }
    }

    void EndGame()
    {
        // �Q�[�����I�����鏈��
        Application.Quit();
    }

    void RetryGame()
    {
        // �V�[���������[�h���鏈��
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
