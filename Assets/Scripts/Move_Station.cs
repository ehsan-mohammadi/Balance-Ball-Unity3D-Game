using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Station : MonoBehaviour {

    public GameObject nextStation;
    public bool move = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && move)
        {
            other.transform.position = nextStation.transform.position;
            move = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            move = true;
        }
    }
}
