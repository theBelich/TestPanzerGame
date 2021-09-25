using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
    public GameObject bullet;

    public float bulletSpeed = 1;

    public float damage = 150;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet.transform.Translate(bulletSpeed, 0, 0);
        Destroy(bullet, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        EnemyStats stat = other.GetComponent<EnemyStats>();
        
        if (stat != null)
        {
            stat.hp -= damage * stat.defence;
        }


    }
}
