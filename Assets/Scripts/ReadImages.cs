using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ReadImages : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager[] trackableImages;

    int ImageToChoose = 0;
    [SerializeField] GameObject[] flowers;
    int flowerToSpawn = 0;

    private void Update() 
    {
        
    }
}
