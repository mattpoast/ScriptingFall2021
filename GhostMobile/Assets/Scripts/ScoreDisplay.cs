using UnityEngine;
public class ScoreDisplay : MonoBehaviour
{
    public int score;
    void Start()
    {
       score = PlayerPrefs.GetInt("Coins");
       print(score);
    }
}
