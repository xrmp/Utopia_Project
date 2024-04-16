using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            // Устанавливаем анимацию бега
            animator.SetTrigger("Run");
        }
       
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
        
            animator.SetTrigger("Idle");
        }
    }
}
