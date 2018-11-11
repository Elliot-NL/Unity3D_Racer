using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 
    public Rigidbody rb;

	// Use this for initialization
	void Start () {

        //Debug.Log("This is a test");
        rb.AddForce(0, 200, 500);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
