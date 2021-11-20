using UnityEngine;
public class Pause : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject unPauseButton;
    public GameObject joyStick;
    public void onButtonTap()
    {
        Time.timeScale = 0f;
        unPauseButton.SetActive(true);
        pauseButton.SetActive(false);
        joyStick.SetActive(false);
    }
}