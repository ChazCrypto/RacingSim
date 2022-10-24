using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class linkList : MonoBehaviour
{
    private void Start()
    {
        LinkedList<string> drivePoints = new LinkedList<string>();


        drivePoints.AddLast("Checkpoint1");
        drivePoints.AddLast("Checkpoint2");
        drivePoints.AddLast("Checkpoint3");
        drivePoints.AddLast("Checkpoint4");
        drivePoints.AddLast("Checkpoint5");
        drivePoints.AddLast("Checkpoint6");
        drivePoints.AddLast("Checkpoint7");
        drivePoints.AddLast("Checkpoint8");



        LinkedListNode<string> node1 = drivePoints.Find("Checkpoint2");
        LinkedListNode<string> node2 = drivePoints.Find("Checkpoint3");
        LinkedListNode<string> node3 = drivePoints.Find("Checkpoint4");
        LinkedListNode<string> node4 = drivePoints.Find("Checkpoint5");
        LinkedListNode<string> node5 = drivePoints.Find("Checkpoint6");
        LinkedListNode<string> node6 = drivePoints.Find("Checkpoint7");
        LinkedListNode<string> node7 = drivePoints.Find("Checkpoint8");
        LinkedListNode<string> node8 = drivePoints.Find("Checkpoint1");



        // drivePoints.RemoveFirst();

        drivePoints.Count();

        



        foreach (var x in drivePoints)
        {


        }
    }
   
}
