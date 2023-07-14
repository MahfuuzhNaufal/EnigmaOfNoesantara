using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMusuh : MonoBehaviour
{
    public GameObject player;
    public GameObject bloodEffect;
    public float speed;
    public int maxHealth = 100;
    public Transform Range;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        if(currentHealth <= 0)
        {
            Die();
        }
        Debug.Log("kena kau");
    }
    void Die()
    {
        Destroy(gameObject);
        Debug.Log("musuh mati");

    }

}
