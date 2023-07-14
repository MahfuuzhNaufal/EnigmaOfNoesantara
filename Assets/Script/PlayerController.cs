using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int coinCount = 0; // Jumlah total koin yang dikumpulkan oleh pemain
    [SerializeField] private Text coinText;

    void Start()
    {
        coinCount = PlayerPrefs.GetInt("X ", coinCount);
    }
    void Update()
    {
        PlayerPrefs.SetInt("X ", coinCount);
    }

    public void AddCoins(int amount)
    {
        coinCount += amount;
        Debug.Log("Jumlah koin: " + coinCount);
        coinText.text = "X " + coinCount;
    }
}
