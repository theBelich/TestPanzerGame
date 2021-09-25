using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject shootingRadius;
    public GameObject[] bullets;
    public GameObject[] weaponChange;

    int weaponNumber = 0;

    public float fireRate = 1.5f;
    float nextFire = 0;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < weaponChange.Length; i++)
        {
            weaponChange[i].SetActive(false);
        }
        weaponChange[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.V))
        {
            weaponChange[weaponNumber].SetActive(false);
            weaponNumber++;
            weaponChange[weaponNumber].SetActive(true);
            if (weaponNumber == bullets.Length)
            {
                weaponNumber = 0;
                
            }
            if (weaponNumber == 0)
            {
                fireRate = 1.5f;
            }
            else if (weaponNumber == 1)
            {
                fireRate = 0.1f;
            }
        }
    }


    private void FixedUpdate()
    {



        

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {


            nextFire = Time.time + fireRate;

            

            Instantiate(bullets[weaponNumber], shootingRadius.transform.position, transform.rotation);
        }        

    }   


}
