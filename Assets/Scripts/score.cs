using UnityEngine;
//imperative for UI (text)
using UnityEngine.UI;

public class score : MonoBehaviour {

    //reference the player position in unity
    public Transform player;

    //reference the text object in unity
    public Text ScoreText;

    //update the text object to the current x value (forwards distance) of the players position
    void Update() {
        ScoreText.text = player.position.x.ToString("0");
    }
}

