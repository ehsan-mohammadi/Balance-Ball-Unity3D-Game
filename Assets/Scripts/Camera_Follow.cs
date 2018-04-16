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
	void Update () 
    {
        transform.position = target.position - distance;
	}
}
