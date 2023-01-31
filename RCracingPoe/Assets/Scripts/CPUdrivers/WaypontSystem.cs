using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypontSystem : MonoBehaviour
{
    [Range(0f, 2f)]
    [SerializeField] private float waypointSize = 1f;
    
    private void OnDrawGizmos()
    {
        foreach (Transform R in transform)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(R.position, waypointSize);
        }

        Gizmos.color = Color.green;
        for (int i = 0; i < transform.childCount-1; i++)
        {
            Gizmos.DrawLine(transform.GetChild(i).position, transform.GetChild(i + 1).position);
        }
        Gizmos.DrawLine(transform.GetChild(transform.childCount - 1).position,transform.GetChild(0).position);
    }
    public Transform GetFollowingWaypoint(Transform WaypointNow)
    {

        if (WaypointNow == null)
        {
            return transform.GetChild(0);
        }
            if (WaypointNow.GetSiblingIndex()<transform.childCount-1)
             {
                 return transform.GetChild(WaypointNow.GetSiblingIndex() + 1);
             }
         else
        
            return transform.GetChild(0);
        
    }
}
