using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool canMove = true;
    public float maxPos;
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            Move();
        }
    }

    void Move(){
        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(xInput, 0, 0);
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
