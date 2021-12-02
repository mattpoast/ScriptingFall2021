using UnityEngine;
public class Pause : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject unPauseButton;
    public GameObject joyStick;
    public GameObject gameMusic, chaseMusic, menuMusic;
    public void onButtonTap()
    {
        Time.timeScale = 0f;
        unPauseButton.SetActive(true);
        pauseButton.SetActive(false);
        joyStick.SetActive(false);
        gameMusic.SetActive(false);
        chaseMusic.SetActive(false);
        menuMusic.SetActive(true);
        
    }
}