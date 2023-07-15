using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextStoryScene : MonoBehaviour
{
    public string LevelToLoad;

    public void NextScene()
    {
        SceneManager.LoadScene(LevelToLoad); 
    }
}
