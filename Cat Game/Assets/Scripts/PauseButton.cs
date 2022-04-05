using UnityEngine;
public class PauseButton : MonoBehaviour
{
    public GameObject pauseButton, pauseScreen;

    public void Start()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        pauseScreen.SetActive(true);
    }
    
}
