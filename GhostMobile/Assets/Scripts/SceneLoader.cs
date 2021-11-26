using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class SceneLoader : MonoBehaviour
{
    public VideoPlayer vid;
    private void Start()
    {
        vid.Play();
        vid.loopPointReached += CheckIfOver;
    }
    void CheckIfOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(0);
    }
}
