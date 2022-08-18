using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneButton : MonoBehaviour
{
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private GameObject _settings;

    [SerializeField] AudioSource audioSource;

    public void PlayButton()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    private void FixedUpdate()
    {
        if (_settings.activeSelf == false)
        {
            _settingsButton.transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
        }
        else if (_settings.activeSelf == true)
        {
            _settingsButton.transform.Rotate(new Vector3(0f, 0f, -50f) * Time.deltaTime);
        }
    }

    public void SettingsButton()
    {
        _settings.SetActive(true);
        audioSource.Play();
    }

    public void SettingsExitButton()
    {
        _settings.SetActive(false);
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("ShopScene");
    }
}
