using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPositionManager : MonoBehaviour
{
    void Start()
    {
        // Trouver le point de spawn avec l'ID sauvegardé
        spawn[] spawnPoints = FindObjectsOfType<spawn>();
        foreach (var spawn in spawnPoints)
        {
            Debug.Log(spawn.spawnPointID + " compare " + gameManager.instance.nextSpawnPointID);
            if (spawn.spawnPointID == gameManager.instance.nextSpawnPointID)
            {
                Debug.Log(spawn);
                Debug.Log(spawn.transform.position);
                transform.position = spawn.transform.position;
                break;
            }
        }
    }
}

