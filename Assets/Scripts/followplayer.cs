using UnityEngine;

public class followplayer : MonoBehaviour {
    //reference the transform (responsible for the position of the player) 
    public Transform player;
    //holds the values that the camera will be away from the player
    public Vector3 offset;

    //update the position of the camera to the position of the player plus the offset value 
    void Update()
    {
        transform.position = player.position + offset;
    }
}
