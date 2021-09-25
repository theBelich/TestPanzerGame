using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public float hp = 7000;
    public float defence = 0.4f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp < 0)
        {
            Instantiate(gameObject, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            
            hp -= collision.gameObject.GetComponent<EnemyStats>().damage * defence;
        }
    }
}
