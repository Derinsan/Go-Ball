using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGame : MonoBehaviour
{
    private bool _isPause = false;
    [SerializeField] private GameObject _panelPause;
    public Transform player;
    [SerializeField] private GameObject _coinSprite;

    private void Awake()
    {
        for (int i = 0; i < player.childCount; i++)
        {
            player.GetChild(i).gameObject.SetActive(false);
        }
        player.GetChild(PlayerPrefs.GetInt("chosenSkin")).gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        Score._playerScore = 0;
    }

    public void ExitGameScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    private void SwitchPauseStatus(bool status)
    {
        Time.timeScale = status ? 1 : 0;
        _isPause = !status;
        _panelPause.SetActive(!status);
    }

    public void PauseButton()
    {
        SwitchPauseStatus(_isPause);
    }

    public void ContinueButton()
    {
        SwitchPauseStatus(_isPause);
    }

    public void ContinueGameNo()
    {
        SceneManager.LoadScene(1);
    }

    private void FixedUpdate()
    {
        _coinSprite.transform.Rotate(new Vector3(0f, 120f, 0f) * Time.deltaTime);
    }
}
