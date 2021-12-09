using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitButton : MonoBehaviour
{
    public string MainMenu;
    public AudioSource buttonClick;
    public void Quit()
    {
        buttonClick.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(MainMenu);
    }
}
