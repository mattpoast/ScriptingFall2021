using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleCanvas : MonoBehaviour
{
    public GameObject GhostColor;
    public  Material[] Colors;
    public int CurrentColorNum;
    public static Material CurrentColor;
    public Material NewColor;
    public string ColorName;
    private void Awake()
    {
        CurrentColorNum = 0;
        CurrentColor = Colors[CurrentColorNum];
        ColorName = "" + CurrentColor;
        ColorName = ColorName.Replace("(UnityEngine.Material)", "");
    }
    public void StartButton()
    {
        Time.timeScale = 1;
       SceneManager.LoadScene(1);
    }
    public void ColorChange()
    {
        NewColor = CurrentColor;
        GhostColor.GetComponent<Renderer>().material = NewColor;
    }
    public void LeftArrow()
    {
        if (CurrentColorNum == 0)
        {
            CurrentColorNum = Colors.Length - 1;
            CurrentColor = Colors[CurrentColorNum];
            ColorName = "" + CurrentColor;
            ColorName = ColorName.Replace("(UnityEngine.Material)", "");
            ColorChange();
        }
        else
        {
            CurrentColorNum--;
            CurrentColor = Colors[CurrentColorNum];
            ColorName = "" + CurrentColor;
            ColorName = ColorName.Replace("(UnityEngine.Material)", "");
            ColorChange();
        }
    }
    public void RightArrow()
    {
        CurrentColorNum++;
        if (CurrentColorNum >= Colors.Length)
            CurrentColorNum = 0;
        CurrentColor = Colors[CurrentColorNum];
        ColorName = "" + CurrentColor;
        ColorName = ColorName.Replace("(UnityEngine.Material)", "");
        ColorChange();
    }
}
