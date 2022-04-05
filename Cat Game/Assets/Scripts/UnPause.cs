using UnityEngine;
public class UnPause : MonoBehaviour
{
    public GameObject pauseButton, pauseScreen;
    public void UnPauseGame()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        pauseScreen.SetActive(false);
    }
}
