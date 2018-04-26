using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

    public Transform target;
    private Quaternion curRotation;

	// Use this for initialization
	void Start () 
    {
        curRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        transform.position = Vector3.Lerp(transform.position, target.position, 10.0f * Time.fixedDeltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, curRotation, 0.125f);

        if (Input.GetKey(KeyCode.Q)) // Rotate to left
        {
            curRotation *= Quaternion.Euler(0, -4, 0);
        }
        else if (Input.GetKey(KeyCode.E)) // Rotate to right
        {
            curRotation *= Quaternion.Euler(0, 4, 0);
        }
	}
}
