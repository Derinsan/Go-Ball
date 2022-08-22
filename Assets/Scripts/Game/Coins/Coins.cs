using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private Text _coinsText;
    private void FixedUpdate()
    {
        int coins = PlayerPrefs.GetInt("coins");
        _coinsText.text = coins.ToString();
    }
}
