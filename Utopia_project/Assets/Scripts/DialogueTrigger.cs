using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogueBox; 
    public string dialogueText = "Press the F button to start the dialog";
    private bool inRange = false;
	public DialogueData dialogueData; 

    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            StartDialogue(); 
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
		{
        if (other.CompareTag("Shaman")) 
		{
            inRange = true;
            dialogueBox.SetActive(true);
            Text textComponent = dialogueBox.GetComponentInChildren<Text>();

            if (textComponent != null) 
			{
                textComponent.text = dialogueText;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Shaman"))
        {
            inRange = false;
            dialogueBox.SetActive(false);
        }
    }

    public void StartDialogue()
    {
    }
}