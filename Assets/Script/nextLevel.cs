using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    // Referensi ke LevelManager
    //public levelManager LevelManager;

    public Animator transition;
    public float transitionTime = 1f;
    // Method ini akan dipanggil ketika pemain menyentuh pintu keluar
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name=="Player")
        {
            //Memuat level berikutnya (Level 2)
            LoadNextLevel();
        }
    }
    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);

    }
}
