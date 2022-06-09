using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{

    //When the beam hits a certain object (enemy).

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //If the collided object has the tag "Boss", pass it into KillEnemy().
        if (collision.CompareTag("Boss"))
        {
            KillEnemy(collision.gameObject);

            Destroy(gameObject);
        }
        else if (collision.CompareTag("Final Boss"))
        {
            KillEnemy(collision.gameObject);

            Destroy(gameObject);

            SceneManager.LoadScene("Win Screen");
        }
    }

    public void KillEnemy(GameObject enemy)
    {

        //Destroy game object.
        Destroy(enemy);

    }
}
