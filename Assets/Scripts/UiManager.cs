using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UiManager : MonoBehaviour
{

    public GameObject infoBox;
    public TMP_Text tmpText;
    // Start is called before the first frame update
    void OnEnable()
    {
        TrackUpdate.OnHover += UpdateInfoBox;
    }
    
    
    void OnDisable()
    {
        TrackUpdate.OnHover -= UpdateInfoBox;
    }

    public void UpdateInfoBox(int id, float time, string name){
        infoBox.SetActive(true);
        tmpText.text = "ID: " + id + "\nTime: " + id + "s\nName:" + name;
    }


}
