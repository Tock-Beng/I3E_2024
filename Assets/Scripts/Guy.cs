/*
 * Author: Tan Tock Beng
 * Date: 06/05/2024
 * Description: 
 * guy that deals damage to player if touched
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guy : MonoBehaviour
{
    /// <summary>
    /// the damage that the guy deals
    /// </summary>
    [SerializeField] private int damage5 = 5;

    private void OnCollisionEnter(Collision collision)
    {
        // check if the colliding object has the player tag
        if (collision.gameObject.tag == "Player")
        {
            // deduct after being touched by player the point by 5 points
            collision.gameObject.GetComponent<Player>().DeductScore(damage5);
            Debug.Log("Ouch! -5 points");
        }
    }
}
