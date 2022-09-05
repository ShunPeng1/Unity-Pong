using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    
    int player1ScoreText = 0;
    int player2ScoreText = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = player1ScoreText.ToString() + " - " + player2ScoreText.ToString();
    }

    public void AddPoint1()
    {
        player1ScoreText++;
        scoreText.text = player1ScoreText.ToString() + " - " + player2ScoreText.ToString();
    }
    public void AddPoint2()
    {
        player2ScoreText++;
        scoreText.text = player1ScoreText.ToString() + " - " + player2ScoreText.ToString();
    }
}
