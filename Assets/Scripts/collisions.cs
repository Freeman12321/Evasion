using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour {

    public movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanagement>().endGame();
        }
    }
}
