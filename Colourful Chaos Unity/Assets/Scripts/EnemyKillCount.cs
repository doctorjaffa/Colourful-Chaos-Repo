using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKillCount : MonoBehaviour
{
    private int killCount = 0;
    private int loadRoom = 4;
    private string nextRoom ;


    public void AddKill()
    {
        killCount++;
        if (killCount > 4)
        {
            SceneManager.LoadScene(nextRoom);
        }
    }

    private void Start()
    {
        nextRoom = PlayerPrefs.GetString("nextRoom");// put in default

        PlayerPrefs.DeleteKey("nextRoom"); // in game over or win scene or title scene
    }

}
