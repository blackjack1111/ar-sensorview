using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class TrackUpdate : MonoBehaviour, IMixedRealityFocusHandler, IMixedRealityPointerHandler
{
    public string trackName;
    public int trackNumber;
    public float timeOfDetection;

    public Transform marker;


public GameObject tooltip;

    Vector3 defaultSize;
    // Start is called before the first frame update
    void Awake()
    {
        defaultSize = marker.localScale;
        tooltip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnFocusEnter(FocusEventData eventData)
    {
        Debug.Log("Enter Focus");
        marker.localScale = defaultSize * 2;
        tooltip.GetComponent<ToolTip>().ToolTipText = GetTooltipText();
        tooltip.SetActive(true);
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        Debug.Log("Exit Focus");
        marker.localScale = defaultSize;
        tooltip.SetActive(false);
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        Debug.Log("Pointer Up");
    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        Debug.Log("Pointer Down");
        
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("Pointer Clicked");
        
    }
    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        Debug.Log("Pointer Dragged");
        
    }

    private string GetTooltipText(){
        return "" + timeOfDetection + "s - " + trackNumber + ": " + trackName;
    }
}
