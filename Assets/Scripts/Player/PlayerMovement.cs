using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject hat;
    public Transform trace;
    public WheelCollider[] wheels; 
    

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
        float vert = Input.GetAxis("Vertical") * speed;
        float horiz = Input.GetAxis("Horizontal");

        wheels[0].motorTorque = vert;
        wheels[1].motorTorque = vert;
        wheels[2].motorTorque = vert;
        wheels[3].motorTorque = vert;

        hat.transform.LookAt(trace);        

        transform.Rotate(0, -1 * horiz, 0);

    }
}
