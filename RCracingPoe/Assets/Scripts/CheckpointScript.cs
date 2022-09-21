using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public Rigidbody rb;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    Stack<GameObject> CheckpointP = new Stack<GameObject>();

    private void SpawnCheckpoint()
    {
        if (CheckpointP.Count > 0)
        {
            GameObject Checkpoint = CheckpointP.Pop();
                Checkpoint.SetActive(true);
        }
        else
        {
            
        }
    }

    private void PassedCheckpoint(GameObject Checkpoint)
    {
        Checkpoint.SetActive(false);
        CheckpointP.Push(Checkpoint);
    }



   /* private void OnTriggerEnter(Collider other)
    {
        if (rb.TryGetComponent<GameObject>(out  gameObject))
        {

        }
    }*/
}
