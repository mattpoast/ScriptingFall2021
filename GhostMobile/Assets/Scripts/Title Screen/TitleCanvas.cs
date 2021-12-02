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
    public bool[] skins;
    private void Awake()
    {
        CurrentColorNum = EquipedColorNum;
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
        skins[CurrentColorNum] = true;
        Equip();
        SkinChecker();
    }
    public void SkinChecker()
    {
        if(skins[CurrentColorNum] == true)
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
