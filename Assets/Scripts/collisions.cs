using UnityEngine;

public class collisions : MonoBehaviour {

    //reference the player movement from unity to tell
    public movement movement;

    //when the player colides with an obstacle disable the movement and call the function endGame in gamemanagement
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<gamemanagement>().EndGame();
        }
    }
}
