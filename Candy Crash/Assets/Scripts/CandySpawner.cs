using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    public GameObject[] candies;
    float maxXPos;
    float maxYPos = 7;

    [SerializeField]float interval;

    public static CandySpawner instance;

    void Awake(){
        maxXPos = GameObject.Find("Player").GetComponent<PlayerControl>().maxPos;

        if(instance == null){
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("Spawn", 2f, 1.5f);
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        //     StartSpawning();
        // if(Input.GetMouseButtonDown(1))
        //     StopSpawning();
    }

    void Spawn(){
        Instantiate(candies[Random.Range(0, candies.Length)], new Vector3(Random.Range(-maxXPos, maxXPos), maxYPos, transform.position.z), Quaternion.identity);
    }

    IEnumerator spawner(){
        yield return new WaitForSeconds(2f);
        while(Score.ScoreManeger.gameOver != true && Score.ScoreManeger.lives > 0){
            Spawn();
            yield return new WaitForSeconds(interval);
        }


    }

    public void StartSpawning(){
        StartCoroutine("spawner");
    }

    public void StopSpawning(){
        StopCoroutine("spawner");
    }
}
