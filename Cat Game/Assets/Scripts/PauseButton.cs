using UnityEngine;
public class PauseButton : MonoBehaviour
{
    public GameObject pauseButton, unPauseButton, menuButton;
    public bool paused;
    public void Start()
    {
        ReadPauseUnPause();
    }
    public void PauseUnPause()
    {
        paused = !paused;
        ReadPauseUnPause();
    }
    public void ReadPauseUnPause()
    {
        if (paused)
        {
            unPauseButton.SetActive(true);
            pauseButton.SetActive(false);
            menuButton.SetActive(true);
        }
        if(paused == false)
        {
            unPauseButton.SetActive(false);
            pauseButton.SetActive(true);
            menuButton.SetActive(false);
        }
    }
}
