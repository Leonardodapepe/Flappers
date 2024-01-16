using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;
    [SerializeField]  public TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI highscoreText;

    

     private int score;

     private void Awake(){
        if (instance == null){
            instance = this;
        }
     }


    private void Start() {

            scoreText.text = score.ToString();
            highscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

            UpdateHighScore();
    }

    public void UpdateHighScore(){
        if (score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", score);
            highscoreText.text = score.ToString();
        }
        }

            public void UpdateScore() {
        score++;
        scoreText.text = score.ToString();
        UpdateHighScore();
    }

}

