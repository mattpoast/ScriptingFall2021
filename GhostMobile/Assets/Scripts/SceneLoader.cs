using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class SceneLoader : MonoBehaviour
{
    public int sceneNumber;
    public VideoPlayer vid;
    private void Start()
    {
        vid.Play();
        vid.loopPointReached += CheckIfOver;
    }
    void CheckIfOver(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
