using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gamemanagement : MonoBehaviour {

    // value to ensure endGame doesnt occur more than once 
    bool gameHasEnded = false;

    // holds the value of lives
    public static int lives = 3;

    // holds the delay in calling endgame
    public float restartDelay = 1f;

    // reference the complete level UI in unity
    public GameObject completeLevelUI;

    // reference the paused level UI in unity
    public GameObject pausedUI;

    // enable the UI for winning a level
    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
    // enable with "p" or disable with "u" the paused UI  
    void Update() {
        if (Input.GetKey("p")) {
            FindObjectOfType<movement>().StopMovement();
            pausedUI.SetActive(true);
            Debug.Log("Level Paused");
        }
        if (Input.GetKey("u")) {
            FindObjectOfType<movement>().RestartMovement();
            pausedUI.SetActive(false);
            Debug.Log("Level Unpaused");
        }
    //end the game only once lose a life reload the scene or lose the game if lives are 0. Invoke calls the function after a delay so we can see the collision or falling of the edge
    }
    public void endGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            lives = lives - 1;
            Invoke("Restart", restartDelay);
            if (lives == 0) {
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

