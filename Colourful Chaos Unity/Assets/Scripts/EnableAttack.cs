using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableAttack : MonoBehaviour
{

    public Button attackButton;

    public void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            attackButton.gameObject.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            attackButton.gameObject.SetActive(false);
        }
    }

}
