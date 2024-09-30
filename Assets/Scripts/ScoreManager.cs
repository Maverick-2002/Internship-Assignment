using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int score;
    public Text Score;
    public AudioSource coin;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
    public void AddPoints(int points)
    {
        score += points;
        coin.Play();
        Score.text = "Score: "+ score.ToString();
    }
    public void ResetScore()
    {
        score = 0;
        Score.text = "Score: " + score.ToString();
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        ResetScore();
    }
    public void Exit()
    {
        Application.Quit();
    }
}