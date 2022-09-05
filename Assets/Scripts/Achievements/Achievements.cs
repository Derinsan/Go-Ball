using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achievements : MonoBehaviour
{
    [SerializeField] GameObject[] textButton;
    [SerializeField] GameObject[] _receivedImage;
    [SerializeField] int _playerScore;
    private bool _received;
    int coins;
    [SerializeField] private Text coinsText;

    private void Start()
    {
        _playerScore = PlayerPrefs.GetInt("recordScore");
        coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
        PlayerPrefs.SetInt("received", _received ? 1 : 0);
    }

    public void GetNoob()
    {
        if (_playerScore >= 500 && _received == true)
        {
            coins += 50;
            PlayerPrefs.SetInt("coins", coins);
            coinsText.text = coins.ToString();
            textButton[0].SetActive(false);
            PlayerPrefs.SetInt("received", 0);
            PlayerPrefs.Save();
            _receivedImage[0].SetActive(true);
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
