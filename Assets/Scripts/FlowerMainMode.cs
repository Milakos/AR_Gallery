using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro;
using UnityEngine.UI;

public class FlowerMainMode : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager imageManager;
    [SerializeField] TMP_Text flowerName;
    [SerializeField] Toggle infoButton;
    [SerializeField] GameObject detailsPanel;
    [SerializeField] TMP_Text detailsText;

    public TMP_Text text;
    [SerializeField] GameObject[] prefabs;
    private Dictionary<string, GameObject> spawnedPrefabs = new Dictionary<string, GameObject>();

    Camera cam;
    int layerMask;

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
    void Start()
    {
        cam = Camera.main;
        layerMask = 1 << LayerMask.NameToLayer("PlacedObjects");
    }

    void OnEnable()
    {
        UIController.ShowUI("Main");

        flowerName.text = "";
        infoButton.interactable = false;
        detailsPanel.SetActive(false);

        text.text ="OnEnable";
        imageManager.trackedImagesChanged += ImageChange;
        print("YEIIIIIIII");
    }

    private void OnDisable() 
    {
        imageManager.trackedImagesChanged -= ImageChange;
       
    }

    void Update()
    {
        if (imageManager.trackables.count == 0)
        {
            Debug.Log("FlowerMainMode no trackables, going to Scan mode");
            InteractionController.EnableMode("Scan");
        }
        else
        {
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                Flower flower = hit.collider.GetComponentInParent<Flower>();
                flowerName.text = flower.flowerName;
                detailsText.text = flower.description;
                infoButton.interactable = true;
            }
            else
            {
                flowerName.text = "";
                detailsText.text = "";
                infoButton.interactable = false;
            }
        }
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