using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float _playerScore;
    [SerializeField] private Text _txt;

    void FixedUpdate()
    {
        _txt.text = $"{_playerScore}";
        if (!PlayerController.isPlayerDead)
        {
            _playerScore++;
        }
    }
}
