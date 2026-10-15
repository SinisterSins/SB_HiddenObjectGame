using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text ScoreText;
    int score;
    public AudioSource sfxCorrect;

    void Start() 
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    public void UpdateScore(int scoreToAdd)
    {
        sfxCorrect.Play();
        score += scoreToAdd;
        ScoreText.text = "Score: " + score;
    }
}
