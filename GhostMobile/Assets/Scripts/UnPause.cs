using UnityEngine;
public class UnPause : MonoBehaviour
{
    public GameObject unPauseButton;
    public GameObject pauseButton;
    public void Start()
    {
        unPauseButton.SetActive(false);
    }
    public void onButtonTap()
    {
        Time.timeScale = 1f;
        pauseButton.SetActive(true);
       unPauseButton.SetActive(false);
    }
}
