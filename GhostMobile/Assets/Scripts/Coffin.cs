using UnityEngine;
using UnityEngine.SceneManagement;

public class Coffin : MonoBehaviour
{
    public Animator animator;
    public void OnTriggerEnter(Collider other)
    {
        if (KeyList.keyCount == 0)
        {
            animator.SetBool("KeyLocked" ,true);
        }
        if (KeyList.keyCount >= 1)
        {
            animator.SetBool("KeyOne", true);
        }
        if (KeyList.keyCount >= 2)
        {
            animator.SetBool("KeyTwo", true);
        }
        if (KeyList.keyCount == 3)
        {
            animator.SetBool("KeyThree", true);
            Invoke("WinGame", 3f);
        }
    }
    public void WinGame()
    {
        SceneManager.LoadScene(3);
    }
}
