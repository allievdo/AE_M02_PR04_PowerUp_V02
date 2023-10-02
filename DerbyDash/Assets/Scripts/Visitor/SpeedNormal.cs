using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PowerUps/SpeedNormalColor")]
public class SpeedNormal : PowerupEffect
{
    public float amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerController>().runningForce -= amount;
        target.GetComponent<SpriteRenderer>().color = Color.blue;
    }
}

