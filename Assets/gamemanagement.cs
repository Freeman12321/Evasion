using UnityEngine;

public class gamemanagement : MonoBehaviour {

    bool gameHasEnded = false;

	public void endGame() {
        if (gameHasEnded == false){
            Debug.Log("Game Over");
        }
    }
}
