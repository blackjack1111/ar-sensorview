using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float scanRate = 4.0f;

    // Update is called once per frame
    void Update()
    {
        float angle = 360.0f / scanRate * Time.deltaTime;
        transform.RotateAround(transform.position, new Vector3(0,-1,0), angle);
    }

    
}
