using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class move : MonoBehaviour
{



    public PlayerInput input;
    private gameManager manager;

    private InputAction moveAction;
    private Vector2 velocity = Vector2.zero;
    private int direction = 0;
    private Animator anim;
    [SerializeField] private float speed = 5f;

    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        manager = gameManager.GetInstance();
        input = manager.GetPlayerInput();
        anim = GetComponent<Animator>();
        moveAction = input.actions.FindAction("Move");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 _moveValue = moveAction.ReadValue<Vector2>();
        _moveValue = ChooseDirection(_moveValue);

        velocity = _moveValue * speed;
        transform.position += new Vector3(velocity.x * Time.fixedDeltaTime, velocity.y * Time.fixedDeltaTime, 0);

        anim.SetInteger("direction", direction);

    }

    private Vector2 ChooseDirection(Vector2 _value)
    {

        if (!canMove)  // Si canMove est false, empêcher le mouvement
        {
            velocity = Vector2.zero;
            anim.SetInteger("direction", 0);  // Réinitialiser l'animation si nécessaire
            return Vector2.zero;
        }

        Vector2 _result = Vector2.zero;

        if (Mathf.Abs(_value.x) >= Mathf.Abs(_value.y))
        {//déplacement en x
            _result = new Vector2(_value.x, 0);
        }
        else
        {
            _result = new Vector2(0, _value.y);
        }
        direction = SetDirection(_result);
        return _result;
    }

    private int SetDirection(Vector2 _vector)
    {
        if (_vector.x > 0)
        {
            return 6;
        }
        if (_vector.x < 0)
        {
            return 4;
        }
        if (_vector.y > 0)
        {
            return 8;
        }
        if (_vector.y < 0)
        {
            return 2;
        }
        return 0;
    }
}
