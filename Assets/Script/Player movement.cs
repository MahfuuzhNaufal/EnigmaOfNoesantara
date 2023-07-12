
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
   public float moveSpeed = 3f;
   public Rigidbody2D rb;
   public Animator animasi;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animasi.SetFloat("Horizontal", movement.x);
        animasi.SetFloat("Vertical", movement.y);
        animasi.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
   