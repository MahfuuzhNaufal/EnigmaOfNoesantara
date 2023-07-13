using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMusuh : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public int maxHealth = 100;
    int currentHealth; 
    // Start is called before the first frame update
    void Start()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("musuh mati");

    }

}
