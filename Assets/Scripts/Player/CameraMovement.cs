using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public float camForce = 1;
    public Transform playerDistance;
    public Vector2 offset = new Vector2(4,5);
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float cameraX = Input.GetAxis("Mouse X") * camForce ;
        //float cameraY = Input.GetAxis("Mouse Y") * Time.deltaTime;

        transform.position = new Vector3(playerDistance.position.x - offset.x, 
                               playerDistance.position.y + offset.y,
                               playerDistance.position.z );

       

        

        //transform.Rotate(0, cameraX, 0);
    }

    

    
}
