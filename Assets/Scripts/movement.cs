using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 50f;
    public float sidewaysForce = 50f;
  
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("d")) {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f) {
            FindObjectOfType<gamemanagement>().endGame();
            sidewaysForce = 0;
        }
        
    }
    public void StopMovement()
    {
        forwardForce = 0;
        sidewaysForce = 0;
        rb.drag = 100;
    }
    public void RestartMovement()
    {
        forwardForce = 30;
        sidewaysForce = 55;
        rb.drag = 1;
    }
}
