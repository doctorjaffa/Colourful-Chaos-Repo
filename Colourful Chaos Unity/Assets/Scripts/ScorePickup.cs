using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{

    public int pickupValue = 10;

    //Called by Unity when this object overlaps with another object.
    //This is the condition.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Only want to do anything if the other object is the player.
        //This is determined if the object has the ScoreTotal script.

        ScoreTotal scoreTotalScript = collision.GetComponent<ScoreTotal>();

        //Check if the ScoreTotal script is on the other object.
        if (scoreTotalScript != null)
        {
            //This means the other object is the player, so the score can be added.

            scoreTotalScript.AddScore(pickupValue);

            Destroy(gameObject);
        }
    }
}
