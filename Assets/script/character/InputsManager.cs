using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerInput))]
public class Inputs : MonoBehaviour
{

    public static Inputs instance {private set; get;}

    private PlayerInput inputs;
    public UnityEvent interactionEvent;

    private InputAction moveAction;
    private void Awake(){
        if(instance!= null){
            Destroy(this);
        }
        instance = this;

        inputs = GetComponent<PlayerInput>();

        moveAction = inputs.actions.FindAction("Move");
    }

    public Vector2 GetMovingInputs(){
        return moveAction.ReadValue<Vector2>();
    }

    public void OnInteract(){
        interactionEvent.Invoke();
    }
}

