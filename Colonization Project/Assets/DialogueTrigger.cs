using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
    public PlayerMotor motor;
    public PlayerController controller;
    public bool playerMoveableTrigger = false;

    void Start()
    {
        motor.enabled = false;
        controller.enabled = false;
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        if (!playerMoveableTrigger)
        {
            motor.enabled = false;
            controller.enabled = false;
        }
        else
        {
            motor.enabled = true;
            controller.enabled = true;
        }
    }
}
