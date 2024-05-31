using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : CollectibleInt
{
    //public float jumpHeightIncreaseAmount = 2.0f;
    public float jumpHeightIncreaseAmount = 5.0f;

    protected override void Collected()
    {
        // Access the player's movement controller and increase jump height
        var controller = GetComponent<StarterAssets.FirstPersonController>();
        if (controller != null)
        {
            controller.JumpHeight += jumpHeightIncreaseAmount;
        }
        base.Collected();
    }
}
