using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Coins.Instance.AddCoins();
            Debug.Log("Количество монет = " + Coins.Instance.coinsCount);
            Destroy(other.gameObject);
        }
    }
}
