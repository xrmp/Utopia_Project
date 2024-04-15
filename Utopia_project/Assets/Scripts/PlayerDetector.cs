using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetection : MonoBehaviour
{
    public float detectionRadius = 5f;
    public GameObject dialogueWindow;
    public Text promptText;
    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            OpenDialogueWindow();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            ShowPrompt();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            HidePrompt();
        }
    }

    void ShowPrompt()
    {
        promptText.text = "Нажмите E, для начала разговора";
    }

    void HidePrompt()
    {
        promptText.text = "";
    }

    void OpenDialogueWindow()
    {
        dialogueWindow.SetActive(true);
    }
}