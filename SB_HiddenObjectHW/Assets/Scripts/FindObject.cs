using UnityEngine;

public class FindObject : MonoBehaviour
{
    private GameManager gameManager;
    public AudioSource sfxWrong;
    private int pointValue = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    public void OnMouseDown()
    {
        if (gameObject.CompareTag("Correct"))
        {           
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            Debug.Log("Hidden Object was found");
        }

        if (gameObject.CompareTag("Incorrect"))
        {
            sfxWrong.Play();
            Debug.Log("Incorrect");
        }
    }
}
