using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMusuh : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
