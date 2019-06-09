using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevelI : MonoBehaviour {
    
    //loads the game again from level 1 and reset lives to 3
    public void LoadLevelI() {
        Debug.Log("Level 1");
        SceneManager.LoadScene("Level-01");
        gamemanagement.lives = 3;
	}
}
