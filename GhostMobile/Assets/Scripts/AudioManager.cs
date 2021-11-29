using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public static AudioClip DoorOpen, DoorClose, ClosetOpen, ClosetClose, KeyPickUp, KeyUnlock, Vacuum, BookCaseOpen, BookCaseClose;
    public static AudioSource audioScource;
    public void Start()
    {
        DoorOpen = Resources.Load<AudioClip>("DoorOpen");
        DoorClose = Resources.Load<AudioClip>("DoorClose");
        ClosetOpen = Resources.Load<AudioClip>("ClosetOpen");
        ClosetClose = Resources.Load<AudioClip>("ClosetClose");
        KeyPickUp = Resources.Load<AudioClip>("KeyPickUp");
        KeyUnlock = Resources.Load<AudioClip>("KeyUnlock");
        Vacuum = Resources.Load<AudioClip>("Vacuum");
        BookCaseOpen = Resources.Load<AudioClip>("BookCaseOpen");
        BookCaseClose = Resources.Load<AudioClip>("BookCaseClose");
        audioScource = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "DoorOpen":
                audioScource.PlayOneShot(DoorOpen);
                break;
            case "DoorClose":
                audioScource.PlayOneShot(DoorClose);
                break;
            case "ClosetOpen":
                audioScource.PlayOneShot(ClosetOpen);
                break;
            case "ClosetClose":
                audioScource.PlayOneShot(ClosetClose);
                break;
            case "KeyPickUp":
                audioScource.PlayOneShot(KeyPickUp);
                break;
            case "KeyUnlock":
                audioScource.PlayOneShot(KeyUnlock);
                break;
            case "Vacuum":
                audioScource.PlayOneShot(Vacuum);
                break;
            case "BookCaseOpen":
                audioScource.PlayOneShot(BookCaseOpen);
                break;
            case "BookCaseClose":
                audioScource.PlayOneShot(BookCaseClose);
                break;
        }
    }
}
