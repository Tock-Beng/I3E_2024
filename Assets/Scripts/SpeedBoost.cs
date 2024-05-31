using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : CollectibleInt
{
    //public float speedIncreaseAmount = 5.0f;
    //public float speedIncreaseAmount = 10.0f;

    //protected override void Collected()
    //{
    //    // Access the player's movement controller and increase speed
    //    var controller = GetComponent<StarterAssets.FirstPersonController>();
    //    if (controller != null)
    //    {
    //        controller.MoveSpeed += speedIncreaseAmount;
    //    }
    //    base.Collected();
    //}

    StarterAssets.FirstPersonController targetPlayer;

    protected override void Collected()
    {
        ActivatePowerUp();

        base.Collected();
    }

    public override void Interact(PlayerInt thePlayer)
    {
        targetPlayer = thePlayer.gameObject.GetComponent<StarterAssets.FirstPersonController>();
        base.Interact(thePlayer);
    }

    public void ActivatePowerUp()
    {
        targetPlayer.MoveSpeed = 10.0f;
    }
}
