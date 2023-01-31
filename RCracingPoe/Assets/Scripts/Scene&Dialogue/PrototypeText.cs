using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class PrototypeText : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting a convo with " + dialogue.name);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        displayNextSentence();

    }
    public void displayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
    public void EndDialogue()
    {
        Debug.Log("End of convo");
    }



}
