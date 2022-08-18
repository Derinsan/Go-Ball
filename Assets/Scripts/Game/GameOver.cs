using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _leftMoveButton;
    [SerializeField] private GameObject _rightMoveButton;
    [SerializeField] Text recordText;

    private void Start()
    {
        int lastRunScore = PlayerPrefs.GetInt("lastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");

        if (lastRunScore > recordScore)
        {
            recordScore = lastRunScore;
            PlayerPrefs.SetInt("recordScore", recordScore);
            PlayerPrefs.GetString("Language");
            if (Localizator.language == "" || Localizator.language == "EN")
            {
                recordText.text = "Record: " + recordScore.ToString();
            }
            else if (Localizator.language == "RU")
            {
                recordText.text = "Рекорд: " + recordScore.ToString();
            }
        }
        else
        {
            if (Localizator.language == "" || Localizator.language == "EN")
            {
                recordText.text = "Record: " + recordScore.ToString();
            }
            else if (Localizator.language == "RU")
            {
                recordText.text = "Рекорд: " + recordScore.ToString();
            }
        }
    }

    private void FixedUpdate()
    {
        if (PlayerController.isPlayerDead == true)
        {
            _panelGameOver.SetActive(true);
            _pauseButton.SetActive(false);
            _leftMoveButton.SetActive(false);
            _rightMoveButton.SetActive(false);
        }
        else if (PlayerController.isPlayerDead == false)
        {
            _panelGameOver.SetActive(false);
            _pauseButton.SetActive(true);
            _leftMoveButton.SetActive(true);
            _rightMoveButton.SetActive(true);
        }
    }
}
