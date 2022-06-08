using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    public EnemyKillCount enemyKill = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hazard enemyScript = collision.gameObject.GetComponent<Hazard>();

        if (enemyScript)
        {
            Destroy(collision.gameObject);

            enemyKill.AddKill();
        }
    }
}
