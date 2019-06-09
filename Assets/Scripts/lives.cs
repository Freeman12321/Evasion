using UnityEngine;
//imperative for using UI 
using UnityEngine.UI;

public class lives : MonoBehaviour {
    //references the text in the score/lives UI in Unity
    public Text LivesText;

    //updates that text to the curent value of lives in gamemanagement
    void Update() {
        LivesText.text = gamemanagement.lives.ToString();
    }
}
