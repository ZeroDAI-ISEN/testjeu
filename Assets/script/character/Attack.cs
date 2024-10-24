using UnityEngine;

public class AttackClass : MonoBehaviour
{
    private SwordHitbox swordHitbox; // Référence à SwordHitbox

    void Start()
    {
        // Trouver le composant SwordHitbox sur le GameObject du triangle
        swordHitbox = GetComponentInChildren<SwordHitbox>(); // Utiliser GetComponentInChildren pour le trouver
        if (swordHitbox == null)
        {
            Debug.LogError("SwordHitbox n'a pas été trouvé dans les enfants !");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("Attaque déclenchée !");
        swordHitbox.CheckHit(); // Appel de CheckHit() au moment de l'attaque
    }
}
