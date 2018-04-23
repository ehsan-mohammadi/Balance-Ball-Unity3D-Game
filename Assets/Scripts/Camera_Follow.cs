using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

    public Transform target;
    private Vector3 distance;

	// Use this for initialization
	void Start () 
    {
        distance = target.position - transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        transform.position = Vector3.Lerp(transform.position, target.position - distance, 10.0f * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.Q)) // Rotate to left
        {
            transform.RotateAround(target.position, Vector3.up, -4);
            distance = target.position - transform.position;
        }
        else if (Input.GetKey(KeyCode.E)) // Rotate to right
        {
            transform.RotateAround(target.position, Vector3.up, 4);
            distance = target.position - transform.position;
        }
	}
}
