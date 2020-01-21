using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player2Score : MonoBehaviour
{
    public GameObject destroy;

    public Text player2;
    public Text winner;
    int playerScore2 = 0;

    void OnCollisionEnter2D(Collision2D col)

    {

        if (col.gameObject.tag == "Ball")
        {
            playerScore2++;
            player2.text = "" + playerScore2;

            if (playerScore2 == 10)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();

                winner.text = "Player 2 wins!";

                Destroy(destroy);

            }

        }
    }
}
