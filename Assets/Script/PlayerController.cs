using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int coinCount = 0; // Jumlah total koin yang dikumpulkan oleh pemain

    public void AddCoins(int amount)
    {
        coinCount += amount;
        Debug.Log("Jumlah koin: " + coinCount);
    }
}
