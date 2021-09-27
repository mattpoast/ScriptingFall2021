using UnityEngine;
public class TriggeredDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("Open Door", true);
    }
    public void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("Close Door", false);
    }
}
