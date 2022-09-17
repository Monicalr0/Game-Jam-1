using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Random.Range(0, 50) == 0)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100)), Quaternion.identity);
        }
    }
}
