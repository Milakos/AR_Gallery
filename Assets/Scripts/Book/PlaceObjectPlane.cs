using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceObjectPlane : MonoBehaviour
{
    [SerializeField] GameObject gameprefab;
    GameObject spawnedObj;
    Vector2 input;
    ARRaycastManager raycaster;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public void Start() 
    {
        raycaster = GetComponent<ARRaycastManager>();
    }
    public void OnPlaceObject(InputValue value) 
    {
        input = value.Get<Vector2>();
        
        if(raycaster.Raycast(input, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;
            
            if (spawnedObj == null)
            {
                spawnedObj = Instantiate(gameprefab,hitPose.position, hitPose.rotation);
            }
            else
            {
                spawnedObj.transform.SetPositionAndRotation(hitPose.position, hitPose.rotation);
            }
        }
    }
}
