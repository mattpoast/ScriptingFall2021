using UnityEngine;
using UnityEngine.UI;
public class ScoreDisplay : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {
        score = PlayerPrefs.GetInt("CoinsWon");
       scoreText.text = "+" + score;
    }
}
