using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 lastPosition;
    private Rigidbody2D physicsBody;

    public int fallDamage = 0;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = gameObject.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))

            lastPosition = gameObject.transform.position;

        if (collision.CompareTag("Death Barrier"))
        {
            PlayerHealth healthScript = GetComponent<PlayerHealth>();

            healthScript.ChangeHealth(-fallDamage);

            gameObject.transform.position = lastPosition;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
