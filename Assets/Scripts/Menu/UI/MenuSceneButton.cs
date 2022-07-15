using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneButton : MonoBehaviour
{
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private GameObject _settings;
    public void PlayButton()
    {
        SceneManager.LoadScene("LoadingScene");
    }
    private void FixedUpdate()
    {
        if (_settings.activeInHierarchy == false)
        {
            _settingsButton.transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
        }
        else if (_settings.activeInHierarchy == true)
        {
            _settingsButton.transform.Rotate(new Vector3(0f, 0f, -50f) * Time.deltaTime);
        }
    }

    public void SettingsButton()
    {
        _settings.SetActive(true);
    }

    public void SettingsExitButton()
    {
        _settings.SetActive(false);
    }
}
