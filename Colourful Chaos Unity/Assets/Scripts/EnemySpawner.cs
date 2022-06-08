using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float enemyInterval = 2.5f;

    private int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {

        if (enemyCount < 15)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6), 0), Quaternion.identity);
            StartCoroutine(spawnEnemy(interval, enemy));
        } else
        {

        }
    }
}
