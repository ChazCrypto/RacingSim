using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class DiagMan2 : MonoBehaviour
{
    public Queue<string> dialoguOptions;
    public Text NameText;
    public Text DescriptionText;

    // Start is called before the first frame update
    void Start()
    {
        dialoguOptions = new Queue<string>();
    }

    public void StartDialogue(Dialogue2 diag)
    {
        
        NameText.text = diag.announcer;
        dialoguOptions.Clear();

        foreach(string sentence in diag.sentences)
        {
            dialoguOptions.Enqueue(sentence);
        }

       
    }
    public void DisplayNextSentence()
    {
        if (dialoguOptions.Count ==0)
        {
            EndDialogue();
            
        }

        string sentence = dialoguOptions.Dequeue();
        DescriptionText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of convo");
    }
}
