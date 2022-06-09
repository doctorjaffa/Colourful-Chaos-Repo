using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public GameObject beamPrefab;
    public Vector2 beamVelocity;
    public Vector3 beamOffset;

    public void FireBeam()
    {
        //Clone the beam.
        //Declare a variable to hold the cloned object. 
        GameObject clonedBeam;

        //Use Instantiate to clone the beam and keep the result in the variable.
        clonedBeam = Instantiate(beamPrefab);

        //Position the beam on the player. 
        clonedBeam.transform.position = (transform.position + beamOffset);

        //Fire beam in a direction.
        //Declare a variable to hold the cloned object's rigidbody.
        Rigidbody2D beamRigidbody;

        //Get the rigidbody from the cloned beam and store it.
        beamRigidbody = clonedBeam.GetComponent<Rigidbody2D>();

        //Set the velocity on the rigidbody to the editor setting. 
        beamRigidbody.velocity = beamVelocity;
    }
}
