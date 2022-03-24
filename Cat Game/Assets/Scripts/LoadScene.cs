using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
  public int sceneNumber;
  public void NextScene()
  {
    SceneManager.LoadScene(sceneNumber);
  }
}
