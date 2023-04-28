using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage = 20;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Life life = other.GetComponent<Life>();
        if (life != null)
        {
            life.amount -= damage;
            Debug.Log("damage = " + damage + "amount = " + life.amount);
        }
    }
}
