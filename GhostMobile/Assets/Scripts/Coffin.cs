using UnityEngine;
using UnityEngine.SceneManagement;
public class Coffin : MonoBehaviour
{
    public Animator animator;
    public static bool wonGame;
    public AudioSource keyUnLock;
    public void Start()
    {
        wonGame = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (KeyList.keyCount == 0)
        {
            animator.SetBool("KeyLocked" ,true);
        }
        if (KeyList.keyCount >= 1)
        {
            animator.SetBool("KeyOne", true);
            keyUnLock.Play();
        }
        if (KeyList.keyCount >= 2)
        {
            animator.SetBool("KeyTwo", true);
            keyUnLock.Play();
        }
        if (KeyList.keyCount == 3)
        {
            animator.SetBool("KeyThree", true);
            keyUnLock.Play();
            Invoke("WinGame", 2.5f);
            wonGame = true;
        }
    }
    public void WinGame()
    {
        SceneManager.LoadScene(3);
    }
}
