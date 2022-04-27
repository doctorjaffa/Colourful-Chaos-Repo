using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public string targetScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Object overlapped with.
        //Check if it is the player. 
        if (collision.CompareTag("Player"))
        {
            //It is the player.
            //Change scene.
            SceneManager.LoadScene(targetScene);
        }

    }
}
