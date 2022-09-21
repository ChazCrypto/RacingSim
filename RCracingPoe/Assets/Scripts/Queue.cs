using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{

    public int[] checkpointOrder = { 1, 2, 3, 4, 5 };

    /*public int StackOrder(int[] _checkpointOrder)
    {
        checkpointOrder = _checkpointOrder;
        int Order;
        return;
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void stackExample()
    {
        Stack<string> stackofLetters = new Stack<string>();
        stackofLetters.Push("a");
        stackofLetters.Push("b");
        stackofLetters.Push("c");

        print(stackofLetters.Peek());
        stackofLetters.Pop();
        print(stackofLetters.Peek());
        stackofLetters.Pop();
        print(stackofLetters.Peek());
    }
}
