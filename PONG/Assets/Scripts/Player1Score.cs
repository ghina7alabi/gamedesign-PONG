using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player1Score : MonoBehaviour
{
    public GameObject destroy;

    public Text player1;
    public Text winner;
    int playerScore1 = 0;

    void OnCollisionEnter2D(Collision2D col)

    {

        if (col.gameObject.tag == "Ball")
        {
            playerScore1++;
            player1.text = "" + playerScore1;

            if (playerScore1 == 10)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();

                winner.text = "Player 1 wins!";

                Destroy(destroy);
            }

        }
    }
}
