using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




[RequireComponent(typeof(Collider2D))]

public abstract class interactableObject : MonoBehaviour
{
    protected bool isReach = false;

    protected bool open = false;

    protected gameManager manager;


    private void Start()
    {
        manager = gameManager.GetInstance();
        Inputs.instance.interactionEvent.AddListener(interact);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isReach = true;
        }
    }

    public abstract void interact();
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isReach = false;
            open = false;
        }
    }
}
