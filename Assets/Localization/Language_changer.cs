using UnityEngine;

public class Language_changer : MonoBehaviour
{
    public void Set_RU()
    {
        string language = "RU";
        PlayerPrefs.SetString("Language", language);
    }

    public void Set_EN()
    {
        string language = "EN";
        PlayerPrefs.SetString("Language", language);
    }
}
