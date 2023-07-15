using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestcontrol : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;
    public int coinAmount;          // Jumlah koin yang diberikan saat membuka peti
    public float interactionDistance;
    private Transform player;            // Transform pemain


    private void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
        animator = GetComponent<Animator>();
        isOpen = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isOpen && Vector2.Distance(transform.position, player.position) <= interactionDistance)
        {
            OpenChest();

        }
    }

    private void OpenChest()
    {
        isOpen = true;
        animator.SetBool("isOpen", true);

        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.AddCoins(coinAmount);
        }
        
        // Tambahkan kode lain yang ingin Anda jalankan ketika peti terbuka.
    }
}
