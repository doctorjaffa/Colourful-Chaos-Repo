using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //The object collided with.
        GameObject otherObject = collision.gameObject;

        //Get the NAME of the object.
        string otherName = otherObject.name;

        //Get the TAG of the object.
        string otherTag = otherObject.tag;

        //Get the LAYER (PHYSICS) of the object.
        int otherLayer = otherObject.layer;

        //Check if a script is attached to the object and, if so, get it.
        //(Getting a component off the object.)
        SpriteRenderer spriteRenderer = otherObject.GetComponent<SpriteRenderer>();

        Debug.Log("Ground reached.");
        Debug.Log("Name: " + otherName);
        Debug.Log("Tag: " + otherTag);
        Debug.Log("Layer: " + otherLayer);
        if (spriteRenderer != null)
            spriteRenderer.color = Color.red;
    }
}
