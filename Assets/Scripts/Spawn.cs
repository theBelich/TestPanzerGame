using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    public float enemyNumbers = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");



        if (enemys.Length < 9)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);

        }
    }
}
