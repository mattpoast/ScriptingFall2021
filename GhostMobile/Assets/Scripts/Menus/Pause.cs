using UnityEngine;
public class Pause : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject unPauseButton;
    public void onButtonTap()
    {
        Time.timeScale = 0f;
        unPauseButton.SetActive(true);
        pauseButton.SetActive(false);
    }
}