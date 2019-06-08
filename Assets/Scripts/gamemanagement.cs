using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanagement : MonoBehaviour {

    bool gameHasEnded = false;

    public static int lives = 3;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }

    public void endGame() {

        if (gameHasEnded == false) {
            gameHasEnded = true;
            lives = lives - 1;
            Invoke("Restart", restartDelay);
            if (lives == 0){

                Invoke("GameOver", restartDelay);
                Invoke("Livesiii", restartDelay);
            }
        }
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void GameOver()
    {
        SceneManager.LoadScene("Game-Over");
    }
    void Livesiii()
    {
        lives = 3;
    }
}

