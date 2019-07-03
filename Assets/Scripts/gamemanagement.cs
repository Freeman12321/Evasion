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

    // references the error message for the user input
    public Text errorMessage;

    // holds the value of the user inputed name
    public string userName;

    // text object that displays username at the end
    public Text userNameText;

    // Input bar for user to type in their user name
    public InputField userInput;

    // collects the User Inputed name value and validates
    // imputs by rejecting invalid ones is called in line 25
    public void CollectUserName(string input) {
        if (input.Length == 0) {
            Debug.Log("Enter Name");
            errorMessage.text = "Please enter a name";
            userName = "";
            userNameText.text = userName;
        }
        else if (input.Length < 2) {
            Debug.Log("Too short");
            errorMessage.text = "Your name is too short (must be between 2 and 14 characters)";
            userName = "";
            userNameText.text = userName;
            userInput.text = "";
        }
        else if (input.Length > 14) {
            Debug.Log("Too Long");
            errorMessage.text = "Your name is too long (must be between 2 and 14 characters)";
            userName = "";
            userNameText.text = userName;
            userInput.text = "";
        }
        else {
            userName = input;
            Debug.Log("You entered " + input);
            errorMessage.text = "";
            userNameText.text = userName;
            userInput.text = userName;
        }
    }
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
        if (Input.GetKey("u") && !Input.GetKey("p")) {
            FindObjectOfType<movement>().RestartMovement();
            pausedUI.SetActive(false);
            Debug.Log("Level Unpaused");
        }
    //end the game only once lose a life reload the scene or lose the game if lives are 0. Invoke calls the function after a delay so we can see the collision or falling of the edge
    }
    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            lives = lives - 1;
            Invoke("Restart", restartDelay);
            Debug.Log("Game Over");
            if (lives == 0) {
                Invoke("GameOver", restartDelay);
                Invoke("Livesiii", restartDelay);
            }
        }
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void GameOver() {
        SceneManager.LoadScene("Game-Over");
    }
    void Livesiii() {
        lives = 3;
    }
}

