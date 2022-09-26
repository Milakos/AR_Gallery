using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class TrackImage : MonoBehaviour
{
    private ARTrackedImageManager trackImage;

    private void Awake() 
    {
        trackImage = FindObjectOfType<ARTrackedImageManager>();    
    }

    private void OnEnable() 
    {
        trackImage.trackedImagesChanged += OnImageChanged;
        
    }

    private void OnDisable()
    {
        trackImage.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var image in args.added)
        {
            Debug.Log("bla");
        }
    }
}
