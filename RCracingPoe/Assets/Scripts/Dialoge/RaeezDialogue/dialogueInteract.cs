using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueInteract : MonoBehaviour
{
    public Dialogue2 diag = new Dialogue2();

    public void TriggerDiag()
    {
        FindObjectOfType<DiagMan2>().StartDialogue(diag);
    }
}
