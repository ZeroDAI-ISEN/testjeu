using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public string nextSpawnPointID;

    // Variable pour savoir si on doit repositionner le joueur
    public bool hasPlayerPositionSaved = false;
    
    [SerializeField] private PlayerInput input;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static gameManager GetInstance(){
        return instance;
    }
 
    public PlayerInput GetPlayerInput(){
        return input;
    }

 }
