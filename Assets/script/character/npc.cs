using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : interactableObject
{
    [SerializeField] private string dialogue;
    [SerializeField] private string title;

    private UIDialogue uiDialogue;

    public GameObject player;  // Référence au joueur
    private move playerMove; 

    private void Awake(){
        uiDialogue = FindObjectOfType<UIDialogue>();
        playerMove = player.GetComponent<move>();
    }
    public override void interact(){
        Debug.Log(isReach);
        if(isReach && open == false){
            uiDialogue.SetDialogue(dialogue,title);
            playerMove.canMove = false; 
            open = true;
        }
        else if(open){
            open = false;
            uiDialogue.CloseDialogue();
            playerMove.canMove = true; 
        }
    }
}
