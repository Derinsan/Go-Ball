using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private GameObject[] interfaceGame;
    [SerializeField] Text recordText;

    public void Awake()
    {
        int lastRunScore = PlayerPrefs.GetInt("lastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");

        if (lastRunScore > recordScore)
        {
            recordScore = lastRunScore;
            PlayerPrefs.SetInt("recordScore", recordScore);
            PlayerPrefs.GetString("Language");
            LanguageRecord();
        }
        else
        {
            LanguageRecord();
        }
    }

    public void LanguageRecord()
    {
        int recordScore = PlayerPrefs.GetInt("recordScore");
        if (Localizator.language == "" || Localizator.language == "EN")
        {
            recordText.text = "Record: " + recordScore.ToString();
        }
        else if (Localizator.language == "RU")
        {
            recordText.text = "Рекорд: " + recordScore.ToString();
        }
    }

    private void FixedUpdate()
    {
        if (PlayerController.isPlayerDead == true)
        {
            _panelGameOver.SetActive(true);
            for (int i = 0; i < interfaceGame.Length; i++)
            {
                interfaceGame[i].SetActive(false);
            }
        }
        else if (PlayerController.isPlayerDead == false)
        {
            _panelGameOver.SetActive(false);
            for (int i = 0; i < interfaceGame.Length; i++)
            {
                interfaceGame[i].SetActive(true);
            }
        }
    }
}
