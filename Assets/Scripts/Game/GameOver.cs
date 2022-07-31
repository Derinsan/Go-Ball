using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _panelGameOver;
    private int _number = 5;

    private void Update()
    {
        if (PlayerController.isPlayerDead == true)
        {
            _panelGameOver.SetActive(true);
        }
    }

    /*IEnumerator ExitGameFive()
    {
        while (_number > 0)
        {
            yield return new WaitForSeconds(1f);
            _text.text = $"{_number}";
            _number--;
            if (_number == 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }*/
}
