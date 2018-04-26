using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {
    
    public float speed = 0.1f;
    public float jump = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        // Up or Down
        if (Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody>().AddForce(Camera.main.transform.parent.forward * speed);
        else if (Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody>().AddForce(Camera.main.transform.parent.forward * -speed);

        // Left or Right
        if (Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody>().AddForce(Camera.main.transform.parent.right * -speed);
        else if (Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody>().AddForce(Camera.main.transform.parent.right * speed);

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
	}
}
