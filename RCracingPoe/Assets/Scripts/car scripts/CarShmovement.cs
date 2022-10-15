using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShmovement : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 Herspers;

    public Vector3 breaks;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(-2f, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(2f, 0, 0, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0, -0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 0, 0.1f, Space.Self);
        }
    }
}
