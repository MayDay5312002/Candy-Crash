using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player"){
            Score.ScoreManeger.incScore();
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Boundary"){
            Score.ScoreManeger.decLives();
            Destroy(gameObject);

        }
    }
}
