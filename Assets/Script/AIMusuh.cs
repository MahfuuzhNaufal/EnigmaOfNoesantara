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
    public Player playerHealt;
    public int damage;
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            playerHealt.TakeDamage(damage);
        }
    }
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
