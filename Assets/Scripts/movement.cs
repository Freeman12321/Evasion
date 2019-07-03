using UnityEngine;

public class movement : MonoBehaviour {
    //reference the rigidbody of the player in unity
    public Rigidbody rb;

    //holds the value of the forwards force
    public float forwardForce = 30f;

    //holds the value of the player controled sideways force
    public float sidewaysForce = 55f;

    //holds the value of the unpaused air drag 
    public float dragUnpaused = 1;

    //holds the value of the paused air drag 
    public float dragPaused = 100;
  
	/* (Fixed is because we are changing physics)Update is called once per frame therefore
    "Time.deltaTime", the reciprical of the framerate means the acceleration is consistent
    with all framerates. when "d" or "a" is held add a force to the left or right 
    respectively always have a forwards movement. End the game if the player falls off the edge. */
	void FixedUpdate () {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("d") || Input.GetKey("l")) {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("j")) {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f) {
            FindObjectOfType<gamemanagement>().EndGame();
            sidewaysForce = 0;
        }
    //functions that are called when the game is paused/unpaused
    }
    public void StopMovement()
    {
        forwardForce = 0;
        sidewaysForce = 0;
        rb.drag = dragPaused;
    }
    public void RestartMovement()
    {
        forwardForce = 30;
        sidewaysForce = 55;
        rb.drag = dragUnpaused;
    }
}
