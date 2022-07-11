using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // -385

public class MenuSceneButton : MonoBehaviour
{
    [SerializeField] private GameObject _settingsButton;
    public void PlayButton()
    {
        SceneManager.LoadScene("LoadingScene");
    }
    private void FixedUpdate()
    {
        _settingsButton.transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
    }

    public void SettingsButton()
    {

    }
}
