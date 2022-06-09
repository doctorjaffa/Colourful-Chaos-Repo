using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstRoom;

    public void StartGame()
    {

        SceneManager.LoadScene(firstRoom);
    }
}
