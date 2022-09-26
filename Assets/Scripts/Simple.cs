using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Simple : MonoBehaviour
{
    private ARRaycastManager rayManager;
    private GameObject visual;
    private void Start() 
    {
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;

        visual.SetActive(false);    
    }
    private void Update() 
    {
      
        List <ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height /2), hits, TrackableType.Planes);

        if(hits.Count > 0)
        {
            if (!visual.activeInHierarchy)
            visual.SetActive(true);
                transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
        
    }
}
