using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialoge_Manager : MonoBehaviour
{
    public TextMeshProUGUI displayRaceName;
    public TextMeshProUGUI displayDialoge;
    public float Speed;
    public Queue<string> Sentences;

    // Start is called before the first frame update
    void Start()
    {
        Sentences = new Queue<string>();
    }

    public void startDialogue(Dialogue RaceDialogue)
    {
        Debug.Log("starting convo with " + RaceDialogue.RaceName);
        displayRaceName.text = Dialogue.RaceName;
        Sentences.Clear();

        foreach (var Sentence in RaceDialogue.sentences)
        {
            Sentences.Enqueue(Sentence);
        }

        displayNextSentence();
    }

    public void displayNextSentence()
    {
        if (Sentences.Count == 0)
        {

            endDialogue();
            return;
        }
        string sentence = Sentences.Dequeue();
        Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(typeSentence(sentence));


        IEnumerator typeSentence(string sentence)
        {
            displayDialoge.text = "";

            foreach (char letter in sentence.ToCharArray())
            {
                displayDialoge.text += letter;
                yield return new WaitForSeconds(Speed);
            }
        }
    }

    public void endDialogue()
    {
        Debug.Log("end of introduction");
    }
}
