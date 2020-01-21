using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketSize : MonoBehaviour
{

    public int sizeOfRacket = 1;


    void OnCollisionEnter2D(Collision2D col)

    {

        if (col.gameObject.tag == "Ball")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            RacketSizer();

        }

    }


    void RacketSizer()
    {
        sizeOfRacket = Random.Range(1, 5);
        transform.localScale = new Vector3(1, sizeOfRacket, 1);
    }



}