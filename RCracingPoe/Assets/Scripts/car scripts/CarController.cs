using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    Rigidbody flyingCar;
    // Start is called before the first frame update
    void Start()
    {
        flyingCar = GetComponent<Rigidbody>();
    }

    public float multiplier;
    public float moveForce;
    public float turnTorque;

    public Transform[] HoverPoints = new Transform[4];
    RaycastHit[] hits = new RaycastHit[4];
    // Update is called once per frame
    private void FixedUpdate()
    {
        for (int i = 0; i < 4; i++)
        {
            ApplyForce(HoverPoints[i], hits[i]);
        }
    }

    void ApplyForce(Transform HoverPoints, RaycastHit hits)
    {
        if (Physics.Raycast(HoverPoints.position,-HoverPoints.up, out hits))
        {
            float force = 0;
            force = Mathf.Abs(1 / (hits.point.y - HoverPoints.position.y));
            flyingCar.AddForceAtPosition(transform.up * force * multiplier,HoverPoints.position, ForceMode.Acceleration);
        }
    }
}
