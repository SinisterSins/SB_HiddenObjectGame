using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text ScoreText;
    int score;
    public AudioSource sfxCorrect;
    public GameObject gameScreen;
    public GameObject endScreen;

    void Start() 
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    void EndGame()
    {
        gameScreen.SetActive(false);
        endScreen.SetActive(true);

    }

    public void UpdateScore(int scoreToAdd)
    {
        sfxCorrect.Play();
        score += scoreToAdd;
        ScoreText.text = "Score: " + score;

        if(score == 6)
        {
            EndGame();
        }
    }
}
