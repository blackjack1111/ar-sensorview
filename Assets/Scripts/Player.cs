using System.Numerics;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour{
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(1, 0 ,0 );
    }
}