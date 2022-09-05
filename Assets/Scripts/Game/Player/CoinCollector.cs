using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private int coins;
    [SerializeField] private Text coinsText;
    public AudioSource audioSource;
    public AudioClip coinCon;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins");
        coinsText.text = coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coins++;
            PlayerPrefs.SetInt("coins", coins);
            coinsText.text = coins.ToString();
            Destroy(other.gameObject);
            audioSource.PlayOneShot(coinCon);
        }
    }
}
