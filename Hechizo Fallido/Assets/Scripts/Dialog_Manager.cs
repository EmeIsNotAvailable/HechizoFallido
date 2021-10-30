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
        foreach (string sentence in dialogo.sentenceList)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    private void OnTrigerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            startDialogue();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
