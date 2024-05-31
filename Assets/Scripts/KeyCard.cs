/*
 * Author: Tan Tock Beng
 * Date: 06/05/2024
 * Description: 
 * The KeyCard will self-destruct upon collision.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class KeyCard : MonoBehaviour
{
    /// <summary>
    /// the door that this card unlocks
    /// </summary>
    public Door linkedDoor;

    private void Start()
    {
        // Check if there is a door that is linked to this card
        if (linkedDoor != null)
        {
            // Lock the door that is linked
            linkedDoor.SetLock(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Deduct 1 collectible from the player
            collision.gameObject.GetComponent<Player>().DeductCollectibles(1);

            // tell the door to unlock itself
            linkedDoor.SetLock(false);
            //destroy the card after unlocking the door
            Destroy(gameObject);
        }
    }
}
