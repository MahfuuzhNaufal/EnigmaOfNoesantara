using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2 : MonoBehaviour
{
    // Referensi ke LevelManager
    //public levelManager LevelManager;
    public string LevelToLoad;

    // Method ini akan dipanggil ketika pemain menyentuh pintu keluar
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            //Memuat level berikutnya (Level 2)
            LoadNextLevel();
        }
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
