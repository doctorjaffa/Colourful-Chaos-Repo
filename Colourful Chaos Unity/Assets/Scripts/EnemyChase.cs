using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    public float forceStrength; //How fast the object moves.
    //public Transform target; //The object being chased.
    public Vector2 targetPosition;

    private Rigidbody2D ourRigidbody; //The rigidbody attached to this object.

    //Awake is called when the script first loads.
    void Awake()
    {
        //Get the rigidbody that will be used for movement. 
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame.
    void Update()
    {
        //Move in the direction of the target.
        //Get the direction. 
        Vector2 direction = ((Vector2)targetPosition - (Vector2)transform.position).normalized;

        //Move in the correct direction with the set force strength. 
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
