using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogo dialogo;
    Queue<string> sentences;
    public GameObject dialog_panel;
    public TextMeshProUGUI displayText;
    string activeSentence;
    public float typingSpeed;
    AudioSource myAudio;
    public AudioClip speakSound;
    void Start()
    {
        sentences = new Queue<string>();
        myAudio = GetComponent<AudioSource>();

    }

    void startDialogue()
    {
        sentences.Clear();
        
        foreach (string sentence in dialogo.sentenceList)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    void DisplayNextSentence()
    {
        if (sentences.Count <= 0)
        {
            displayText.text = activeSentence;
            return;
        }
        activeSentence = sentences.Dequeue();
        Debug.Log(activeSentence);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        { 
            startDialogue();
            print("Chocasion");
        }
    } 
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown("space"))
            {
                DisplayNextSentence();
                print("poia pero mejor");
            }
            print("poia");
        }
    }/*
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DisplayNextSentence();
            }
        }
    }*/
}
