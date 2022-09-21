using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float Speed = 0.1f;
    Rigidbody car;
    

    
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");


        Vector3 moveDirection = new Vector3(xDirection, 0.0f,zDirection);

        transform.position += moveDirection * Speed;
        
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0, -0.5f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 0, 0.5f, Space.World);
        }
    }
}
