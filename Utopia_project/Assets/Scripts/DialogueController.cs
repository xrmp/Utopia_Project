using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] public Text textSummoner;
    [SerializeField] public GameObject dialogWindow;
    [SerializeField] public float triggerDistance = 5f;

    private bool dialogActive = false;
    
    void Update()
    {
        float distance = Vector3.Distance(transform.position, transform.position);

        if (distance <= triggerDistance && !dialogActive)
        {
            textSummoner.text = "Press the F button to start the dialogue!";
            textSummoner.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                textSummoner.gameObject.SetActive(false);
                dialogWindow.SetActive(true);
                dialogActive = true;
            }
        }
    }
}