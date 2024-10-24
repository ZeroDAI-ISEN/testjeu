using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    public Transform swordHitbox; // Référence à la hitbox (le triangle)
    public float distanceFromPlayer = 1.0f; // Distance de la hitbox par rapport au personnage

    void Update()
    {
        // Obtenir la direction de regard
        Vector3 direction = GetLookDirection();

        // Ajuster la rotation de la hitbox en tenant compte de l'inversion (180 degrés)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f + 180f; // Inversion du triangle
        swordHitbox.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // Placer la hitbox à une certaine distance devant le personnage
        swordHitbox.position = transform.position + direction.normalized * distanceFromPlayer;
    }

    // Fonction pour obtenir la direction du regard
    Vector3 GetLookDirection()
    {
        // Si tu utilises les touches fléchées ou un joystick pour le mouvement
        Vector3 lookDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        // Si le personnage ne bouge pas, garder la direction par défaut (vers le bas)
        if (lookDirection != Vector3.zero)
        {
            return lookDirection;
        }

        // Retourner la direction par défaut (vers le bas)
        return -transform.up;
    }
}
