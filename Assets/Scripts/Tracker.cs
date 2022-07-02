using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{

    public List<TrackUpdate> trackUpdateList;
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
        TrackUpdate newUpdate = trackUpdateList[currentIndex];
        newUpdate.trackName = detection.gameObject.name;
        newUpdate.trackNumber = detection.gameObject.GetInstanceID();
        newUpdate.timeOfDetection = Time.time;
        newUpdate.transform.position = detection.transform.position;
        currentTrackUpdateMarker.Translate(detection.transform.position - currentTrackUpdateMarker.position,Space.World);
        newUpdate.gameObject.SetActive(true);
        currentIndex ++;
        if (currentIndex >= trackUpdateList.Capacity){
            currentIndex = 0;
        }

    }
}
