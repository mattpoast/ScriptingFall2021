using UnityEngine;
using UnityEngine.SceneManagement;
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
    private void Awake()
    {
        CurrentColorNum = PlayerPrefs.GetInt("EquipedColor");
        currentColor = Colors[CurrentColorNum];
        GhostColor.GetComponent<Renderer>().material = currentColor;
        SkinChecker();
    }
    public void StartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void Equip()
    {
        EquipedColorNum = CurrentColorNum;
        PlayerPrefs.SetInt("EquipedColor", EquipedColorNum);
    }
    public void ColorChange()
    {
        SkinChecker();
        NewColor = currentColor;
        GhostColor.GetComponent<Renderer>().material = NewColor;
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
    public void BuyButtonFunction()
    {
        if (CurrentColorNum == 1)
        {
            PlayerPrefs.SetInt("Blue", 1);
        }
        if (CurrentColorNum == 2)
        {
            PlayerPrefs.SetInt("Pink", 1);
        }
        if (CurrentColorNum == 3)
        {
            PlayerPrefs.SetInt("Purchased3", 1);
        }
        if (CurrentColorNum == 4)
        {
            PlayerPrefs.SetInt("Purchased4", 1);
        }
        if (CurrentColorNum == 5)
        {
            PlayerPrefs.SetInt("Purchased5", 1);
        }
        if (CurrentColorNum == 6)
        {
            PlayerPrefs.SetInt("Purchased6", 1);
        }
        Equip();
        SkinChecker();
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
