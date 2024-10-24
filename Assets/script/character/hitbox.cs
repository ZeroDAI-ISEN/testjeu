using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    private bool isObjectInHitbox = false; // Indique si un objet est dans la hitbox
    private GameObject objectInHitbox; // Référence à l'objet dans la hitbox
    public string targetTag = "Enemy"; // Tag de l'objet à détecter

    // Méthode publique appelée par AttackClass au moment de l'attaque
    public void CheckHit()
    {
        if (isObjectInHitbox && objectInHitbox.CompareTag(targetTag)) // Vérifie le tag de l'objet
        {
            Debug.Log("Attaque réussie sur l'ennemi : " + objectInHitbox.name);
        }
        else
        {
            Debug.Log("Attaque manquée, aucun ennemi dans la hitbox");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Objet entré dans la hitbox : " + other.gameObject.name);

        if (other.CompareTag(targetTag))
        {
            isObjectInHitbox = true; // L'objet est dans la hitbox
            objectInHitbox = other.gameObject;
            Debug.Log(objectInHitbox.name + " (Enemy) est dans la hitbox");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == objectInHitbox)
        {
            isObjectInHitbox = false; // L'objet a quitté la hitbox
            objectInHitbox = null;
            Debug.Log("Objet a quitté la hitbox");
        }
    }
}
