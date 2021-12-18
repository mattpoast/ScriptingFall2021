using UnityEngine;
using UnityEngine.SceneManagement;
public class Coffin : MonoBehaviour
{
    public Animator animator;
    public static bool wonGame;
    public AudioSource keyUnLock;
    public AudioSource wonSoundEffect;
    public float clock;
    public int timeBonus;
    public int coinsWon;
    public void Start()
    {
        wonGame = false;
        clock = 0;
    }
    public void FixedUpdate()
    {
        clock += 1 * Time.deltaTime;
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
            if (clock <= 120)
            {
                coinsWon = 15;
                PlayerPrefs.SetInt("CoinsWon", coinsWon);
                timeBonus = PlayerPrefs.GetInt("Coins");
                timeBonus += 15;
                PlayerPrefs.SetInt("Coins", timeBonus);
            }
            if (clock > 120 && clock < 200)
            {
                coinsWon = 10;
                PlayerPrefs.SetInt("CoinsWon", coinsWon);
                timeBonus = PlayerPrefs.GetInt("Coins");
                timeBonus += 10;
                PlayerPrefs.SetInt("Coins", timeBonus);
            }
            if (clock > 200)
            {
                coinsWon = 5;
                PlayerPrefs.SetInt("CoinsWon", coinsWon);
                timeBonus = PlayerPrefs.GetInt("Coins");
                timeBonus += 5;
                PlayerPrefs.SetInt("Coins", timeBonus); 
            }
            animator.SetBool("KeyThree", true);
            keyUnLock.Play();
            wonSoundEffect.Play();
            Invoke("WinGame", 2.5f);
            wonGame = true;
        }
    }
    public void WinGame()
    {
        SceneManager.LoadScene(6);
    }
}
