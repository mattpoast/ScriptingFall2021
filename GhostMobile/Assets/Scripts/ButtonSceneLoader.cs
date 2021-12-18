using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonSceneLoader : MonoBehaviour
{
   public int scene;
   public void MainMenu()
   {
      SceneManager.LoadScene(scene);
   }
}
