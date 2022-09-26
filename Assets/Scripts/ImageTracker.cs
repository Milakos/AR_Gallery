using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;

public class ImageTracker : MonoBehaviour
{
    public TMP_Text text;

    [SerializeField] ARTrackedImageManager imageManager;
    [SerializeField] GameObject[] prefabs;
    private Dictionary<string, GameObject> spawnedPrefabs = new Dictionary<string, GameObject>();
    private void Awake() 
    {
        text.text = "";
        imageManager = FindObjectOfType<ARTrackedImageManager>();

        foreach(GameObject pf in prefabs)
        {
            GameObject go  = Instantiate(pf, Vector3.zero, Quaternion.identity);
            
            go.name = pf.name;
            spawnedPrefabs.Add(pf.name, go);
            go.SetActive(false);
        }
    }

    public void OnEnable() 
    {
        text.text ="OnEnable";
        imageManager.trackedImagesChanged += ImageChange;
    }

    private void OnDisable() 
    {
        imageManager.trackedImagesChanged -= ImageChange;
       
    }

    private void ImageChange(ARTrackedImagesChangedEventArgs eventArgs)
    {
        
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            text.text = "Added";
            ChangeLocation(trackedImage.referenceImage.name, trackedImage.transform.position, trackedImage.transform.rotation, true);
        }
        
        foreach (ARTrackedImage trackedImage in eventArgs.updated)
        {
            ChangeLocation(trackedImage.referenceImage.name, trackedImage.transform.position, trackedImage.transform.rotation, true);
            text.text = "Update";

            if(trackedImage.trackingState == TrackingState.Limited)
            {
                ChangeLocation(trackedImage.referenceImage.name, Vector3.zero, Quaternion.identity, false);
                text.text = "Removed";
            }
        }
    }

    void ChangeLocation (string name, Vector3 ob, Quaternion quat, bool vis)
    {
            spawnedPrefabs[name].transform.position = ob;
            spawnedPrefabs[name].transform.rotation = quat;
            spawnedPrefabs[name].SetActive(vis);
    }
}
