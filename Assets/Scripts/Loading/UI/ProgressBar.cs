using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Scrollbar progress;
    [SerializeField] Text _textUI;
    private string _text = "...";
    private string _textLoading;

    private void Awake()
    {
        if (Localizator.language == "" || Localizator.language == "EN")
        {
            _textLoading = "Loading";
            _textUI.fontStyle = FontStyle.Normal;
        }
        else if (Localizator.language == "RU")
        {
            _textLoading = "Загрузка";
            _textUI.fontStyle = FontStyle.Bold;
        }
    }

    private void Start()
    {
        progress = GetComponent<Scrollbar>();
        StartCoroutine(GoProgress());
        StartCoroutine(Loading(_text));
    }
    IEnumerator GoProgress()
    {
        while (progress.size < 100)
        {
            yield return new WaitForSeconds(1f);
            progress.size += 0.25f;
            if (progress.size == 1)
            {
                SceneManager.LoadScene("GameScene");
                break;
            }
        }
    }

    IEnumerator Loading(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {
            _textUI.text = _textLoading + text.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.8f);
        }
    }
}
