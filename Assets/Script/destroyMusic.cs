using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyMusic : MonoBehaviour
{
    public string LevelToLoad;

    public void NextSceneNoMus()
    {
        Destroy(GameObject.Find("Audio Source"));
        SceneManager.LoadScene(LevelToLoad); 
    }
}
