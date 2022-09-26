using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// using UnityEngine.XR.ARFoundation;
// using UnityEngine.XR.ARSubsystems;
public class EditPictureMode : MonoBehaviour
{
    public FramedPhoto currentPicture;
    [SerializeField] SelectImageMode selectImage;
    // [SerializeField] ARRaycastManager raycatser;
    // List<ARRaycastHit> hits = new List<ARRaycastHit>();
    Camera cam;

    private void Start() 
    {
        cam = Camera.main;    
    }
    private void OnEnable() 
    {
        UIController.ShowUI("EditPicture");    
        if (currentPicture)
            currentPicture.BeingEdited(true);
    }
    void OnDisable() 
    {
        if (currentPicture)
            currentPicture.BeingEdited(false);    
    }

    public void OnSelectObject(InputValue value)
    {             
        Vector2 touchPosition = value.Get<Vector2>();
        FindObjectToEdit(touchPosition);
    }

    void FindObjectToEdit(Vector2 touchPosition)
    {
        Ray ray = cam.ScreenPointToRay(touchPosition);
        RaycastHit hit;

        int layerMask = 1 << LayerMask.NameToLayer("PlacedObjects");

        if(Physics.Raycast(ray, out hit, 50f, layerMask))
        {
            if(hit.collider.gameObject != currentPicture.gameObject)
            {
                currentPicture.BeingEdited(false);
                FramedPhoto picture = hit.collider.GetComponentInParent<FramedPhoto>();
                currentPicture = picture;
                picture.BeingEdited(true);
            }
        }
    }

    public void DeletePicture()
    {
        GameObject.Destroy(currentPicture.gameObject);
        InteractionController.EnableMode("Main");
    }

    public void SelectImageToReplace()
    {
        selectImage.isReplacing = true;
        InteractionController.EnableMode("SelectImage");
    }
}
