using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToScene : MonoBehaviour
{
    public int sceneNumber;

    public void SceneLoader()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
