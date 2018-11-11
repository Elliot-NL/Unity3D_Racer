using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        //Use build index 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
