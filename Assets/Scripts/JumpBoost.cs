using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : CollectibleInt
{
    StarterAssets.FirstPersonController targetPlayer;
    //public float jumpHeightIncreaseAmount = 2.0f;

    protected override void Collected()
    {
        ActivatePowerUp();

        base.Collected();
    }
        // Access the player's movement controller and increase jump height
        /*
        var controller = GetComponent<StarterAssets.FirstPersonController>();
        if (controller != null)
        {
            controller.JumpHeight += jumpHeightIncreaseAmount;
        }
        base.Collected();
        }
        */

    public override void Interact(PlayerInt thePlayer)
    {
        targetPlayer = thePlayer.gameObject.GetComponent<StarterAssets.FirstPersonController>();
        base.Interact(thePlayer);
    }

    public void ActivatePowerUp()
    {
        targetPlayer.JumpHeight = 6.0f;
    }
}
