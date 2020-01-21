using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public int speed = 30;
 

	// Use this for initialization
	void Start () {
        

        int randomDirection = Random.Range(0, 2);

        if (randomDirection < 1)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }

        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        

	}
	

    void OnCollisionEnter2D(Collision2D col)

    {

       if (col.gameObject.tag == "LeftRacket")
       {
            BallSpeed();
            Debug.Log(speed);

       }

       if (col.gameObject.tag == "RightRacket")
       {
            BallSpeed();
            Debug.Log(speed);
       }


    }
    

    void BallSpeed()
    {
        //speed = Random.Range(0, 4);
        int addSpeed = 10;
        speed = speed + addSpeed;


    }

  

}

