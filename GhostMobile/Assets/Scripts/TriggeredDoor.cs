using UnityEngine;
public class TriggeredDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public AudioSource doorOpen;
    public AudioSource doorClose;
    public void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("Open Door", true);
        doorOpen.Play();
    }
    public void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("Open Door", false);
        doorClose.Play();
    }
}
