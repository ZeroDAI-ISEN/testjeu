using UnityEngine;

public class AttackClass : MonoBehaviour
{
    public int valeur;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Valeur initiale : " + valeur);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
    }

    // Function that logs an attack message
    void Attack()
    {
        Debug.Log("Attaque déclenchée !");
    }
}
