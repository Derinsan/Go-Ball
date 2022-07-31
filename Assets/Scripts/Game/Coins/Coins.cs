using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinsCount { get; private set; } = 0;
    public static Coins Instance { get; private set; } = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else Destroy(gameObject);
    }

    public void AddCoins(int count)
    {
        coinsCount += count;
    }

    public void AddCoins()
    {
        coinsCount++;
    }
}
