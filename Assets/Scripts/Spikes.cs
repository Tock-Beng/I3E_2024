/*
 * Author: Tan Tock Beng
 * Date: 06/05/2024
 * Description: 
 * spikes that deals damage to player if touched
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    /// <summary>
    /// the damage that the spike deals
    /// </summary>
    public int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        // check if the colliding object has the player tag
        if (collision.gameObject.tag == "Player")
        {
            // deduct after being touched by player the point by 1 point
            collision.gameObject.GetComponent<Player>().DeductScore(damage);
            Debug.Log("Ouch! -1 point");
        }
    }
}
