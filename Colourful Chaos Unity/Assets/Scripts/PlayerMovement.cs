using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3.0f;
    public float jumpForce = 150f;

    public int jumpCharge = 1;
    public Collider2D jumpSensor;

    private Rigidbody2D physicsBody = null;


    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

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

        //Get rigidbody needed to find physics information.
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //Find out what the current horizontal and vertical speeds are.
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        //Get the animation that will be used for movement. 
        Animator ourAnimator = GetComponent<Animator>();

        //Tell the animator what the speeds are.
        ourAnimator.SetFloat("speedH", currentSpeedH);
        ourAnimator.SetFloat("speedV", currentSpeedV);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
            jumpCharge = 1;
    }

    public void MoveUp()
    {
        if (jumpCharge > 0)
        {

            physicsBody.AddForce(Vector2.up * jumpForce);
            jumpCharge--;
        }
    }

    public void Attack()
    {
        this.GetComponent<Animator>().SetTrigger("isAttacking");
    }

    public void MoveRight()
    {

        Vector2 newVel = new Vector2(moveSpeed, 0);

        physicsBody.velocity = newVel;
    }

    public void MoveLeft()
    {

        Vector2 newVel = new Vector2(moveSpeed, 0);

        physicsBody.velocity = -newVel;
    }
}
