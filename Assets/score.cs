using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text ScoreText;

    void Update()
    {
        ScoreText.text = player.position.x.ToString("0");
    }
}

