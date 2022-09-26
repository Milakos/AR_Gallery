using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class ShowTrackablesOnEnable : MonoBehaviour
{
    [SerializeField] ARSessionOrigin sessionOrigin;
    ARPlaneManager planeManager;
    ARPointCloudManager cloudManager;

    bool isStarted;

    private void Awake() 
    {
        planeManager = sessionOrigin.GetComponent<ARPlaneManager>();
        cloudManager = sessionOrigin.GetComponent<ARPointCloudManager>();    
    }

    private void Start() 
    {
        isStarted = true;    
    }

    private void OnEnable() 
    {
        ShowTrackables(true);    
    }

    private void OnDisable() 
    {
        if (isStarted)
        {
            ShowTrackables(false);
        }
    }

    private void ShowTrackables(bool show)
    {
        if (cloudManager)
        {
            cloudManager.SetTrackablesActive(show);
            cloudManager.enabled = show;
        }
        if (planeManager)
        {
            planeManager.SetTrackablesActive(show);
            planeManager.enabled = show;
        }
    }
}
