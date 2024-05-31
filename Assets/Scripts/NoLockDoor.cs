/*
 * Author: Tan Tock Beng
 * Date: 06/05/2024
 * Description: 
 * door that opens when player is near it and closes itself after player is no longer near it
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoLockDoor : MonoBehaviour
{
    /// <summary>
    /// Flags if the door is open
    /// </summary>
    bool opened = false;

    private void OnTriggerEnter(Collider other)
    {
        //Check if the object entering the trigger has the "Player" tag
        if (other.gameObject.tag == "Player" && !opened)
        {
            //If it is the player, Open the door
            OpenDoor();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Check if the object entering the trigger has the "Player" tag and If it is the player and the door is already opened
        if (other.gameObject.tag == "Player" && opened)
        {
            // invoke the CloseDoor method after a 2-second delay
            Invoke("CloseDoor", 2f);
        }
    }



    /// <summary>
    /// Handles the door opening
    /// </summary>
    void OpenDoor()
    {
        //Create a new Vector 3(x,y,z) and store the current rotation.
        Vector3 newRotation = transform.eulerAngles;
        //Make it turn 90 degrees
        newRotation.y += 90f;
        //Assign new rotation to the transform
        transform.eulerAngles = newRotation;
        opened = true;
    }

    /// <summary>
    /// handles the door closing
    /// </summary>
    void CloseDoor()
    {
        // Close the door by rotating it back to its original rotation
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y -= 90f;
        transform.eulerAngles = newRotation;

        opened = false;
    }
}
