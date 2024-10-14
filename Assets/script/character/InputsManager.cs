using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/*
public class Inputs : MonoBehaviour
{

    public static InputsManager instance{private set; get;}

    private PlayerInput inputs;

    private InputAction moveAction;
    private void Awake(){
        if(instance!= null){
            Destroy(this);
        }
        instance = this;

        inputs = GetComponent<PlayerInpu>();

        moveAction = inputs.actions.FindAction("Move");
    }

    public Vector2 GetMovingInputs(){
        return moveAction.ReadValue<Vector2>();
    }
}
*/
