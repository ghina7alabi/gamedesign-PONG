using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour {

    public GameObject ball;
   

    public void Start () {
        Invoke("CreateBall", 2);
	}

    public void CreateBall()
    {
        Instantiate(ball, new Vector3(0,0,0), Quaternion.identity);
    }
    
}
