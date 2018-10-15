using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Delay : MonoBehaviour {

    public float timeToDestroy = 0f;

	// Use this for initialization
	void Start () 
    {
        Destroy(gameObject, timeToDestroy);
	}
}
