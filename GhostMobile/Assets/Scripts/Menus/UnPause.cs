using UnityEngine;
public class UnPause : MonoBehaviour
{
    public GameObject unPauseButton;
    public GameObject pauseButton;
    public GameObject joyStick;
    public GameObject gameMusic, chaseMusic, menuMusic;
    
    public void Start()
    {
        unPauseButton.SetActive(false);
    }
    public void onButtonTap()
    {
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
       unPauseButton.SetActive(false);
       joyStick.SetActive(true);
       gameMusic.SetActive(true);
       menuMusic.SetActive(false);
       chaseMusic.SetActive(false);
    }
}
