using UnityEngine;

public class SwordRotation : MonoBehaviour
{
    public Transform swordHitbox; // Référence au triangle représentant la hitbox de l'épée
    public float distanceFromPlayer = 1.0f;

    void Update()
    {
        // Gérer l'orientation et la position de la hitbox
        Vector3 direction = GetLookDirection();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f + 180f;
        swordHitbox.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        swordHitbox.position = transform.position + direction.normalized * distanceFromPlayer;
    }

    Vector3 GetLookDirection()
    {
        Vector3 lookDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        return lookDirection != Vector3.zero ? lookDirection : -transform.up;
    }
}
