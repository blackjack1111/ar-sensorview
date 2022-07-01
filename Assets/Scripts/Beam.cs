using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(message: "Collision with: " + other);
    }
    
}
