using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneButton : MonoBehaviour
{
    public static MenuSceneButton S;
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private GameObject _settings;

    [SerializeField] AudioSource audioSource;

    private void Awake()
    {
        S = this;
        InterstilialAd.S.LoadAd();
        RewardedAds.S.LoadAd();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    private void FixedUpdate()
    {
        if (_settings.activeInHierarchy == false)
        {
            _settingsButton.transform.Rotate(new Vector3(0, 0, 50f) * Time.deltaTime);
        }
        if (_settings.activeInHierarchy == true)
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

    public void AchievementsButton()
    {
        SceneManager.LoadScene("AchievementsScene");
    }
}
