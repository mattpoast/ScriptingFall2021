using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public string MainMenu;
    public void Quit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MainMenu);
    }
}
