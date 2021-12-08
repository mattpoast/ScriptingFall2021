using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleCanvas : MonoBehaviour
{
    public GameObject GhostColor;
    public  Material[] Colors;
    public int CurrentColorNum;
    public Material currentColor;
    public Material NewColor;
    public static int EquipedColorNum;
    public GameObject buyButton;
    public GameObject equipButton;
    public int[] purchased;
    public GameObject checkMark;
    public int coins;
    public int[] price;
    public Text priceText;
    public Text coinAmmount;
    public AudioSource notEnoughCoins;
    public AudioSource boughtSkin;
    private void Awake()
    {
        CurrentColorNum = PlayerPrefs.GetInt("EquipedColor");
        currentColor = Colors[CurrentColorNum];
        GhostColor.GetComponent<Renderer>().material = currentColor;
        SkinChecker();
        Equip();
        CheckMark();
        PriceCheck();
        CoinUpdate();
    }
    public void StartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Equip()
    {
        EquipedColorNum = CurrentColorNum;
        PlayerPrefs.SetInt("EquipedColor", EquipedColorNum);
        CheckMark();
        SkinChecker();
    }
    public void ColorChange()
    {
        CheckMark();
        SkinChecker();
        NewColor = currentColor;
        GhostColor.GetComponent<Renderer>().material = NewColor;
        PriceCheck();
    }
    public void PriceCheck()
    {
        if (purchased[CurrentColorNum] == 0)
        {
            priceText.gameObject.SetActive(true);
            priceText.text = price[CurrentColorNum].ToString();
        }
        else
        {
            priceText.gameObject.SetActive(false);
        }
    }
    public void LeftArrow()
    {
        if (CurrentColorNum == 0)
        {
            CurrentColorNum = Colors.Length - 1;
            currentColor = Colors[CurrentColorNum];
            ColorChange();
        }
        else
        {
            CurrentColorNum--;
            currentColor = Colors[CurrentColorNum];
            ColorChange();
        }
    }
    public void RightArrow()
    {
        CurrentColorNum++;
        if (CurrentColorNum >= Colors.Length)
            CurrentColorNum = 0;
        currentColor = Colors[CurrentColorNum];
        ColorChange();
    }
    public void CheckMark()
    {
        if (CurrentColorNum == EquipedColorNum)
        {
            checkMark.SetActive(true);
        }
        else
        {
            checkMark.SetActive(false);
        }
    }
    public void CoinUpdate()
    {
        coinAmmount.text = coins.ToString(); 
    }
    public void BuyButtonFunction()
    {
        if (coins <= price[CurrentColorNum])
        {
            notEnoughCoins.Play();
        }
        if (CurrentColorNum == 1 && coins >= price[CurrentColorNum])
        {
            PlayerPrefs.SetInt("Blue", 1);
            Equip();
            BoughtSkin();
        }
        if (CurrentColorNum == 2 && coins >= price[CurrentColorNum])
        {
            PlayerPrefs.SetInt("Pink", 1);
            Equip();
            BoughtSkin();
        }
        if (CurrentColorNum == 3 && coins >= price[CurrentColorNum])
        {
            PlayerPrefs.SetInt("Purchased3", 1);
            Equip();
            BoughtSkin();
        }
        if (CurrentColorNum == 4 && coins >= price[CurrentColorNum])
        {
            PlayerPrefs.SetInt("Purchased4", 1);
            Equip();
            BoughtSkin();
        }
        if (CurrentColorNum == 5 && coins >= price[CurrentColorNum])
        {
            PlayerPrefs.SetInt("Purchased5", 1);
            Equip();
            BoughtSkin();
        }
        if (CurrentColorNum == 6 && coins >= price[CurrentColorNum])  
        {
            PlayerPrefs.SetInt("Purchased6", 1);
            Equip();
            BoughtSkin();
        }
        SkinChecker();
    }
    public void BoughtSkin()
    {
        coins -= price[CurrentColorNum];
        coinAmmount.text = coins.ToString();
        PriceCheck();
        boughtSkin.Play();
    }
    public void SkinChecker()
    {
        if (CurrentColorNum == 1 & PlayerPrefs.GetInt("Blue") == 1)
        {
            purchased[CurrentColorNum] = 1;
        }
        if (CurrentColorNum == 2 & PlayerPrefs.GetInt("Pink") == 1)
        {
            purchased[CurrentColorNum] = 1;
        }
        if (CurrentColorNum == 3 & PlayerPrefs.GetInt("Purchased3") == 1)
        {
            purchased[CurrentColorNum] = 1;
        }
        if (CurrentColorNum == 4 & PlayerPrefs.GetInt("Purchased4") == 1)
        {
            purchased[CurrentColorNum] = 1;
        }
        if (CurrentColorNum == 5 & PlayerPrefs.GetInt("Purchased5") == 1)
        {
            purchased[CurrentColorNum] = 1;
        }
        if (CurrentColorNum == 6 & PlayerPrefs.GetInt("Purchased6") == 1)
        {
            purchased[CurrentColorNum] = 1;
        }
        if (purchased[CurrentColorNum] == 1)
        {
            equipButton.SetActive(true);
            buyButton.SetActive(false);
        }
        else
        {
            equipButton.SetActive(false);
            buyButton.SetActive(true);
        }
    }
}
