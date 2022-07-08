using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float _playerScore;
    [SerializeField] private Text _txt;

    private void Start()
    {
        StartCoroutine(ScoreCounter());
    }

    IEnumerator ScoreCounter()
    {
        while (!PlayerController.isPlayerDead)
        {
            yield return new WaitForSeconds(0.030f);
            _playerScore++;
            _txt.text = $"{_playerScore}";
        }
    }
}
