using UnityEngine;
public class PauseButton : MonoBehaviour
{
    public GameObject pauseButton, pauseScreen;

    public void Start()
    {
        pauseScreen.SetActive(false);
    }
    public void PauseGame()
    {
        pauseButton.SetActive(false);
        pauseScreen.SetActive(true);
    }
    
}
