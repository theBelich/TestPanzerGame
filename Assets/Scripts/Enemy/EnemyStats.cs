using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float hp = 150;
    public float defence = 0.3f;
    public float damage = 15;
    public float moveSpeed = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp < 0)
        {
            Destroy(gameObject);
        }
    }
}
