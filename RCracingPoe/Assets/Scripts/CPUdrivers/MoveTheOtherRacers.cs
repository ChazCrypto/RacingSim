using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheOtherRacers : MonoBehaviour
{
    [SerializeField] private WaypontSystem waypont;

    [SerializeField] private float moveSpeed;

     Transform presentWaypoint;
    public float distance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        presentWaypoint = waypont.GetFollowingWaypoint(presentWaypoint);
        transform.position = presentWaypoint.position;
        presentWaypoint = waypont.GetFollowingWaypoint(presentWaypoint);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, presentWaypoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position,presentWaypoint.position)<distance)
        {
            presentWaypoint = waypont.GetFollowingWaypoint(presentWaypoint);
        }
    }
}
