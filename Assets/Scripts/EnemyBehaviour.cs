using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private GameObject player;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.y != 0) {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if (other.collider.tag == "Player")
        {
            Debug.Log("Health -1");
            Destroy(gameObject);
        }
    }
}
