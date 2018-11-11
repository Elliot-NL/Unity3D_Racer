using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gamehasended = false;

    public float restartDelay = 1.5f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        //Debug.Log("You have completed the level");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("The game has ended");

            //Restart game here:
            Invoke("Restart", restartDelay);

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
