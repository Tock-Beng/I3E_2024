/*
 * Author: Tan Tock Beng
 * Date: 06/05/2024
 * Description: 
 * collectibles that reward players with points upon collision
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    /// <summary>
    /// the value that these collectible is worth
    /// </summary>

    public int goldCoin = 1;
    public int goldPot = 5;
    public int goldBar = 10;


    /// <summary>
    /// when collectible is collected
    /// </summary>
    void Collected()
    {
        //destroy gameObject after being touched
        Destroy(gameObject);
        //Debug.Log("I got collected");
    }

    /// <summary>
    /// method is called when collectible collides with another object or player
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // check if the colliding object has the "player" tag
        if (collision.gameObject.tag == "Player")
        {
            //look for the "GoldCoin" tag and increase 1 point
            if (gameObject.tag == "GoldCoin")
            {
                collision.gameObject.GetComponent<Player>().IncreaseScore(goldCoin);
            }
            //look for the "GoldPot" tag and increase 5 points
            else if (gameObject.tag == "GoldPot")
            {
                collision.gameObject.GetComponent<Player>().IncreaseScore(goldPot);
            }
            //look for the "GoldBar" tag and increase 10 points
            else if (gameObject.tag == "GoldBar")
            {
                collision.gameObject.GetComponent<Player>().IncreaseScore(goldBar);
            }
            //destroy the collectible after collision
            Collected();

        }
    }
}
