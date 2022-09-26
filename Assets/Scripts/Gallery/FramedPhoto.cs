using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramedPhoto : MonoBehaviour
{
    [SerializeField] Transform scalerObject;
    [SerializeField] GameObject imageObject;
    [SerializeField] Collider boundingCollider;
    [SerializeField] GameObject highlightObject;
    bool isEditing;
    int layer;
    ImageInfo imageInfo;
    MovePicture movePicture;
    ResizePIcture resizePIcture;

    private void Awake() 
    {
        movePicture = GetComponent<MovePicture>();
        resizePIcture = GetComponent<ResizePIcture>();
        movePicture.enabled = false;
        resizePIcture.enabled = false;
        layer = LayerMask.NameToLayer("PlacedObjects");
        Highlight(false);
    }
    public void SetImage(ImageInfo image)
    {
        imageInfo = image;

        Renderer renderer = imageObject.GetComponent<Renderer>();
        Material material = renderer.material;
        material.SetTexture("_BaseMap", imageInfo.texture);
        AdjustScale();
    }
    public void AdjustScale()
    {
        Vector2 scale = ImagesData.AspectRatio(imageInfo.width, imageInfo.height);
        scalerObject.localScale = new Vector3(scale.x, scale.y, 1f);
    }
    public void BeingEdited(bool editing)
    {
        Highlight(editing);
        movePicture.enabled = editing;
        resizePIcture.enabled = editing;
        isEditing = editing;
    }
    public void Highlight(bool show)
    {
        if (highlightObject)
            highlightObject.SetActive(show);
    }

    void OnTriggerStay(Collider other) 
    {
        const float spacing = 0.1f;
        
        if(isEditing && other.gameObject.layer == layer)
        {
            Bounds bounds = boundingCollider.bounds;
            if(other.bounds.Intersects(bounds))
            {
                Vector3 centerDistance = bounds.center - other.bounds.center;
                Vector3 distOnPlane = Vector3.ProjectOnPlane(centerDistance,transform.forward);
                Vector3 direction = distOnPlane.normalized;
                float distanceToMoveThisFrame = bounds.size.x * spacing;
                transform.Translate(direction * distanceToMoveThisFrame);
            }
        }
    }
}
