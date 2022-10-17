using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class linkList : MonoBehaviour
{
    private void Start()
    {
        LinkedList<string> trackPoints = new LinkedList<string>();

        trackPoints.AddLast("aaa");

        foreach (var x in trackPoints)
        {
           // Console.WriteLine(x);


        }
            
    }
   
}
