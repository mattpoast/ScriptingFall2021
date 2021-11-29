using UnityEngine;
public class TriggeredDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("Open Door", true);
        if (gameObject.CompareTag("Door"))
        {
            AudioManager.PlaySound("DoorOpen");
        }
        if (gameObject.CompareTag("Closet"))
        {
            AudioManager.PlaySound("ClosetOpen");
        }
        if (gameObject.CompareTag("BookCase"))
        {
            AudioManager.PlaySound("BookCaseOpen");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        doorAnimator.SetBool("Open Door", false);
        if (gameObject.CompareTag("Door"))
        {
            AudioManager.PlaySound("DoorClose");
        }
        if (gameObject.CompareTag("Closet"))
        {
            AudioManager.PlaySound("ClosetClose");
        }
        if (gameObject.CompareTag("BookCase"))
        {
            AudioManager.PlaySound("BookCaseClose");
        }
    }
}
