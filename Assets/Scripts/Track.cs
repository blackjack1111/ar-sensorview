using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    public float speed;
    public double radius;
    public double altitude;

    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.position;
        angle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
        this.transform.localEulerAngles = new Vector3(0, -angle, 0);
        Vector3 translation = transform.forward * speed * Time.deltaTime;
        transform.Translate(translation,Space.World);
    }

}
