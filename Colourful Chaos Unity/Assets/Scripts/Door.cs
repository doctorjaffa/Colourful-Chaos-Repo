using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public string targetScene;
    public string roomToSet;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Object overlapped with.
        //Check if it is the player. 
        if (collision.CompareTag("Player"))
        {
            PlayerPrefs.SetString("nextRoom", roomToSet); // done when leaving other room to update new room to go to

            //It is the player.
            //Change scene.
            SceneManager.LoadScene(targetScene);
        }

    }
}
