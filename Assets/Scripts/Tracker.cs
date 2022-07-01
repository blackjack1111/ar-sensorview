using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{

    public List<GameObject> trackUpdateList;
    public Transform currentTrackUpdateMarker;

    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void processDetection(Collider detection){
        GameObject newUpdate = trackUpdateList[currentIndex];
        newUpdate.transform.position = detection.transform.position;
        currentTrackUpdateMarker.Translate(detection.transform.position - currentTrackUpdateMarker.position,Space.World);
        newUpdate.SetActive(true);
        currentIndex ++;
        if (currentIndex >= trackUpdateList.Capacity){
            currentIndex = 0;
        }

    }
}
