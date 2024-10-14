using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;        // Nom de la scène à charger
    public string spawnPointID;       // Identifiant du prochain point de spawn dans la scène à charger

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Sauvegarder l'identifiant du point de spawn avant de charger la scène suivante
            gameManager.instance.nextSpawnPointID = spawnPointID;

            Debug.Log(spawnPointID);

            // Charger la scène spécifiée
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
        }
    }
}
