using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 50f;
    public float sidewaysForce = 50f;
  
	// Update is called once per frame
	void Update () {
        rb.AddForce(forwardForce, 0, 0);
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewaysForce);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewaysForce);
        }
    }
}
