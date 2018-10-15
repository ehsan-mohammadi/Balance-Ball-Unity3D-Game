using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour {

    public GameObject nextBall;
    public GameObject Explosion;

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<BoxCollider>().enabled = false;
            GameObject newBall = Instantiate(nextBall, other.transform.position, Quaternion.identity);
            GameObject prevBall = Camera.main.transform.parent.GetComponent<Camera_Follow>().target.gameObject;
            Camera.main.transform.parent.GetComponent<Camera_Follow>().target = newBall.transform;
            Destroy(prevBall);

            // Show explosion
            Instantiate(Explosion, newBall.transform.position, Quaternion.identity);
        }
    }
}
