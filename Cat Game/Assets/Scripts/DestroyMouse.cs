using UnityEngine;
public class DestroyMouse : MonoBehaviour
{
    public GameObject mouse;
    public AudioSource mouseDeathSound;
    public void OnMouseDown()
    {
        mouseDeathSound.Play();
        mouse.SetActive(false);
        Destroy(mouse,1.5f);
    }
}
