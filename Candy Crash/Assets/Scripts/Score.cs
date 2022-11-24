using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score ScoreManeger;

    public GameObject livesHolder;

    public GameObject gameOverPanel;
    int score = 0;
    [HideInInspector] public int lives = 4;

    public Text scoreText;
    // public Image[] livesImage;

    [HideInInspector]public bool gameOver = false;
    // Start is called before the first frame update
    void Awake(){
        if(ScoreManeger == null){
            ScoreManeger = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incScore(){
        if(!gameOver){
            score++;
            scoreText.text = score.ToString();
        }
        //print("Score: " + score);
    }

    public void decLives(){
        if(lives > 0){
        lives--;
        livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        // Destroy(livesImage[lives]);
        }
        if(lives == 0){
            gameOver = true;
            GameOver();
        }
        print("Lives: " + lives);
    }
    public void GameOver(){
        print("GameOver!");
        gameOverPanel.SetActive(true);
        CandySpawner.instance.StopSpawning();
        GameObject.Find("Player").GetComponent<PlayerControl>().canMove = false;
    }
}
