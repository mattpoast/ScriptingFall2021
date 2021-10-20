using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleCanvas : MonoBehaviour
{
    public GameObject GhostColor;
    public Material[] Colors;
    public int CurrentColorNum;
    public Material CurrentColor;
    public Material NewColor;
    public string GameScene;
    public Text ColorText;
    private void Awake()
    {
        CurrentColorNum = 0;
        CurrentColor = Colors[CurrentColorNum];
        ColorText.text = "" + CurrentColor;
    }
    public void StartButton()
    {
       SceneManager.LoadScene(GameScene);
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
            ColorText.text = "" + CurrentColor;
            //ColorText.text = 
            ColorChange();
        }
        else
        {
            CurrentColorNum--;
            CurrentColor = Colors[CurrentColorNum];
            ColorText.text = "" + CurrentColor;
            ColorChange();
        }
    }
    public void RightArrow()
    {
        CurrentColorNum++;
        if (CurrentColorNum >= Colors.Length)
            CurrentColorNum = 0;
        CurrentColor = Colors[CurrentColorNum];
        ColorText.text = "" + CurrentColor;
        ColorChange();
    }
}
