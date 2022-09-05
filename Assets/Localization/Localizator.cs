using UnityEngine;
using UnityEngine.UI;

public class Localizator : MonoBehaviour
{
    public static string language = "";
    Text text;

    public string textRU;
    public string textEN;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        language = PlayerPrefs.GetString("Language");

        if (language == "" || language == "EN")
        {
            text.text = textEN;
            text.fontStyle = FontStyle.Normal;
        }
        else if (language == "RU")
        {
            text.text = textRU;
            text.fontStyle = FontStyle.Bold;
        }
    }
}
