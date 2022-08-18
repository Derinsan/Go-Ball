using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SkinChanger : MonoBehaviour
{
    public Skin[] info;
    private bool[] StockCheck;

    public Button buyBttn;
    public Text priceText;
    public Text coinsText;
    public Transform player;
    public int index;

    public int coins;
    [SerializeField] AudioSource _buySound;
    [SerializeField] AudioSource _scrollSound;

    private void Awake()
    {
        coins = PlayerPrefs.GetInt("coins");
        index = PlayerPrefs.GetInt("chosenSkin");
        coinsText.text = coins.ToString();

        StockCheck = new bool[10];
        if (PlayerPrefs.HasKey("StockArray"))
            StockCheck = PlayerPrefsX.GetBoolArray("StockArray");

        else
            StockCheck[0] = true;

        info[index].isChosen = true;

        for (int i = 0; i < info.Length; i++)
        {
            info[i].inStock = StockCheck[i];
            if (i == index)
                player.GetChild(i).gameObject.SetActive(true);
            else
                player.GetChild(i).gameObject.SetActive(false);
        }

        if (Localizator.language == "" || Localizator.language == "EN")
        {
            priceText.text = "CHOSEN";
        }
        else if (Localizator.language == "RU")
        {
            priceText.text = "Выбрано";
        }
        buyBttn.interactable = false;
    }

    public void Save()
    {
        PlayerPrefsX.SetBoolArray("StockArray", StockCheck);
    }

    public void ScrollRight()
    {
        if (index < player.childCount - 1)
        {
            index++;

            if (info[index].inStock && info[index].isChosen)
            {
                if (Localizator.language == "" || Localizator.language == "EN")
                {
                    priceText.text = "CHOSEN";
                }
                else if (Localizator.language == "RU")
                {
                    priceText.text = "Выбрано";
                }
                buyBttn.interactable = false;
            }
            else if (!info[index].inStock)
            {
                priceText.text = info[index].cost.ToString();
                buyBttn.interactable = true;
            }
            else if (info[index].inStock && !info[index].isChosen)
            {
                if (Localizator.language == "" || Localizator.language == "EN")
                {
                    priceText.text = "CHOOSE";
                }
                else if (Localizator.language == "RU")
                {
                    priceText.text = "Выбрать";
                }
                buyBttn.interactable = true;
            }

            for (int i = 0; i < player.childCount; i++)
                player.GetChild(i).gameObject.SetActive(false);
            // Можно записать так: player.GetChild(index-1).gameObject.SetActive(false);

            player.GetChild(index).gameObject.SetActive(true);

            _scrollSound.Play();
        }
    }

    public void ScrollLeft()
    {
        if (index > 0)
        {
            index--;

            if (info[index].inStock && info[index].isChosen)
            {
                if (Localizator.language == "" || Localizator.language == "EN")
                {
                    priceText.text = "CHOSEN";
                }
                else if (Localizator.language == "RU")
                {
                    priceText.text = "Выбрано";
                }
                buyBttn.interactable = false;
            }
            else if (!info[index].inStock)
            {
                priceText.text = info[index].cost.ToString();
                buyBttn.interactable = true;
            }
            else if (info[index].inStock && !info[index].isChosen)
            {
                if (Localizator.language == "" || Localizator.language == "EN")
                {
                    priceText.text = "CHOOSE";
                }
                else if (Localizator.language == "RU")
                {
                    priceText.text = "Выбрать";
                }
                buyBttn.interactable = true;
            }

            for (int i = 0; i < player.childCount; i++)
                player.GetChild(i).gameObject.SetActive(false);

            player.GetChild(index).gameObject.SetActive(true);

            _scrollSound.Play();
        }
    }

    public void BuyButtonAction()
    {
        if (buyBttn.interactable && !info[index].inStock)
        {
            if (coins > int.Parse(priceText.text))
            {
                coins -= int.Parse(priceText.text);
                coinsText.text = coins.ToString();
                PlayerPrefs.SetInt("coins", coins);
                StockCheck[index] = true;
                info[index].inStock = true;
                _buySound.Play();
                if (Localizator.language == "" || Localizator.language == "EN")
                {
                    priceText.text = "CHOOSE";
                }
                else if (Localizator.language == "RU")
                {
                    priceText.text = "Выбрать";
                }
                Save();
            }
        }

        if (buyBttn.interactable && !info[index].isChosen && info[index].inStock)
        {
            PlayerPrefs.SetInt("chosenSkin", index);
            buyBttn.interactable = false;
            if (Localizator.language == "" || Localizator.language == "EN")
            {
                priceText.text = "CHOSEN";
            }
            else if (Localizator.language == "RU")
            {
                priceText.text = "Выбрано";
            }
        }
    }

    public void ShopExit()
    {
        SceneManager.LoadScene("MenuScene");
    }
}


[System.Serializable]
public class Skin
{
    public int cost;
    public bool inStock;
    public bool isChosen;
}
