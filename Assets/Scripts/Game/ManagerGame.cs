using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGame : MonoBehaviour
{
    private bool _isPause = false;
    [SerializeField] private GameObject _panelPause;

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        Score._playerScore = 0;
        Score._playerScore += 1;
    }

    private void SwitchPauseStatus(bool status)
    {
        Time.timeScale = status ? 1 : 0;
        _isPause = !status;
        _panelPause.SetActive(!status);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchPauseStatus(_isPause);
        }
    }
}