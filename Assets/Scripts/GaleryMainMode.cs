using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class GaleryMainMode : MonoBehaviour
{
    [SerializeField] EditPictureMode editMode;
    [SerializeField] SelectImageMode selectImage;
    Camera cam;

     void Start() 
    {
        cam = Camera.main;    
    }
    private void OnEnable() 
    {
        UIController.ShowUI("Main");    
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
        
        // Debug.DrawRay(touchPosition, Vector3.forward, Color.blue, 100f, true);

        int layerMask = 1 << LayerMask.NameToLayer("PlacedObjects");

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            FramedPhoto picture = hit.collider.GetComponentInParent<FramedPhoto>();
            editMode.currentPicture = picture;
            InteractionController.EnableMode("EditPicture");
        }
    }
    public void SelectImageToAdd()
    {
        selectImage.isReplacing = false;
        InteractionController.EnableMode("SelectImage"); 
        //"AddPicture"
    }
    // public void SelectImageToEdit()
    // {
    //     InteractionController.EnableMode("EditPicture");
    //     FindObjectToEdit(touchPosition); 
    // }
}
