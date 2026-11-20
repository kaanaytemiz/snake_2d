using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score=0;
    public int highScore;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore" , 0);  
        highScoreText.text= "HighScore: " + highScore; 
    }
    private void Awake()
    {
        Instance = this;
    }
    
    
    
    public void AddScore()
    {
        score++;
        if( score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore" , highScore);
            PlayerPrefs.Save();

        }
        scoreText.text = "Score: " + score;
        highScoreText.text= "HighScore: " + highScore;
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
