using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startgame : MonoBehaviour {
    //loads the game again from level 1 and reset lives to 3

    public Text errorMessage;

    public void LoadLevelI() {
        if (FindObjectOfType<gamemanagement>().userName != "") {
            Debug.Log("Level 1");
            SceneManager.LoadScene("Level-01");
            gamemanagement.lives = 3;
        }
        else {
            errorMessage.text = "Please Enter a valid Username (press enter in input bar)";
        }
    }
    public void RestartGame() {
        SceneManager.LoadScene("Level-01");
        gamemanagement.lives = 3;
    }
    
        
        /*FindObjectOfType<gamemanagement>().CollectUserName(UserInput.text);
        if (errorMessage.text == "") {
            Debug.Log("Level 1");
            SceneManager.LoadScene("Level-01");
            gamemanagement.lives = 3;
        }
        */

}

