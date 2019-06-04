using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanagement : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public void endGame()
    {

        //lose a life and only end the game once
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

