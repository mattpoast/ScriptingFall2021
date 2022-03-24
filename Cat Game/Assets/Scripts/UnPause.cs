using UnityEngine;
public class UnPause : MonoBehaviour
{
    public GameObject pauseButton, pauseScreen;
    public void UnPauseGame()
    {
        pauseButton.SetActive(true);
        pauseScreen.SetActive(false);
    }
}
