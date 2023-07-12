using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public int coinAmount = 10;          // Jumlah koin yang diberikan saat membuka peti
    public float interactionDistance;
    public Sprite openSprite; // Sprite peti terbuka


    private bool isOpen = false;         // Menandakan apakah peti sudah terbuka
    private SpriteRenderer spriteRenderer; // Referensi ke komponen SpriteRenderer
    public Sprite closedSprite;             // Sprite peti tertutup
    private Transform player;            // Transform pemain


    private void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
        spriteRenderer = GetComponent<SpriteRenderer>(); // Mengambil referensi ke komponen SpriteRenderer
        closedSprite = spriteRenderer.sprite;            // Menyimpan sprite peti tertutup
    }

    private void Update()
    {
        // Periksa jika pemain menekan tombol "E" dan peti belum terbuka dan jarak cukup
        if (Input.GetKeyDown(KeyCode.E) && !isOpen && Vector3.Distance(transform.position, player.position) <= interactionDistance)
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        isOpen = true;

        // Tambahkan koin ke pemain
        PlayerController player = FindObjectOfType<PlayerController>();
        if (player != null)
        {
            player.AddCoins(coinAmount);
        }

        // Lakukan tindakan lain, seperti animasi peti terbuka, suara, dll.
        // ...
    }
}
