using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3.0f;

    private Rigidbody2D physicsBody = null;

    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Ask Unity's Input Manager for the current value of the horizontal axis.
        //This will be between -1 and 1. 
        float axisValX = Input.GetAxis("Horizontal");
        float axisValY = Input.GetAxis("Vertical");

        //Use axes values to set up a new velocity vector.
        Vector2 newVel = new Vector2(axisValX, axisValY);

        //Scale our velovity based on a speed.
        //Goes from -speed to +speed.
        newVel *= moveSpeed;

        //Tell the physics rigidbody to use the new velocity.
        physicsBody.velocity = newVel;
    }
}
