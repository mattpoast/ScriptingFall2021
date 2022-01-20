using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }
}
