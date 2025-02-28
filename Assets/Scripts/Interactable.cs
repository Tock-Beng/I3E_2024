/*
 * Author: Tan Tock Beng
 * Date: 20/05/2024
 * Description: 
 * Contains functions related to the Interactable
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    /// <summary>
    /// Stores the current player that can interact with the object
    /// </summary>
    protected PlayerInt currentPlayer;

    /// <summary>
    /// Update the player's Interactable
    /// </summary>
    /// <param name="thePlayer">The player to update</param>
    public void UpdatePlayerInteractable(PlayerInt thePlayer)
    {
        thePlayer.UpdateInteractable(this);
    }

    /// <summary>
    /// Remove the player's Interactable
    /// </summary>
    /// <param name="thePlayer">The player that should remove its Interactable</param>
    public void RemovePlayerInteractable(PlayerInt thePlayer)
    {
        thePlayer.UpdateInteractable(null);
    }

    /// <summary>
    /// Execute the object's interaction
    /// </summary>
    /// <param name="thePlayer">The player that interacted with the object</param>
    public virtual void Interact(PlayerInt thePlayer)
    {
        Debug.Log(gameObject.name + " was interacted with.");
    }

}

