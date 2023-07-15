using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    // Referensi ke LevelManager
    //public levelManager LevelManager;


    // Method ini akan dipanggil ketika pemain menyentuh pintu keluar
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //Memuat level berikutnya (Level 2)
            LoadNextLevel();
        }
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
