using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public Tracker tracker;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(message: "Collision with: " + other);
        if (other.tag == "Detectable"){
            tracker.processDetection(other);

        }
    }
    
}
