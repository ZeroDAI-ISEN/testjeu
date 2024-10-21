using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] GameObject spriteSpawn;      

    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 position = spriteSpawn.transform.position;
        if (other.CompareTag("Player"))
        {
            player.transform.position = new Vector3(position.x, position.y, 0);
        }
    }
}
