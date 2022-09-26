// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using RotaryHeart.Lib.SerializableDictionary;
// using UnityEngine.XR.ARFoundation;
// using UnityEngine.XR.ARSubsystems;
// using TMPro;
// using UnityEngine.UI;

// [System.Serializable]
// public class FlowerPrefabDictionary : SerializableDictionaryBase<string, GameObject> { }
// public class ARTrackeImageAndSpawn : MonoBehaviour
// {
    
//     [SerializeField] ARTrackedImageManager imageManager;
//     [SerializeField] FlowerPrefabDictionary flowerPrefabs;

//     private void Awake() 
//     {
//         imageManager = GetComponent<ARTrackedImageManager>();    
//     }
//     private void OnEnable() 
//     {
//         foreach (ARTrackedImage image in imageManager.trackables)
//         {
//             InstantiateFlower(image);
//         }
//         imageManager.trackedImagesChanged += OnTrackedImageChanged;    
//     }

//     private void OnDisable() 
//     {
//         imageManager.trackedImagesChanged -= OnTrackedImageChanged;
//     }


//     void OnTrackedImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
//     {
//         foreach (ARTrackedImage newImage in eventArgs.added)
//         {
//             InstantiateFlower(newImage);
//         }
//         foreach (ARTrackedImage newImage in eventArgs.updated)
//         {
//             if(newImage.trackingState == TrackingState.Tracking)
//             {
//                 AssignGameObject(newImage);
//             }
//         }

//         // foreach (ARTrackedImage removedImage in eventArgs.removed)
//         // {
//         //    // Handle removed event
//         //    Debug.Log("removed " + removedImage.referenceImage.name);
//         //    removedImage.gameObject.SetActive(false);

//         // }
//     }

//     void AssignGameObject(ARTrackedImage rTrackedImage)
//     {
//             GameObject goARObject = flowerPrefabs[rTrackedImage.referenceImage.name];
//             // goARObject.SetActive(true);
//             goARObject.transform.position = rTrackedImage.transform.position;
//             goARObject.transform.rotation = rTrackedImage.transform.rotation;
//             goARObject.SetActive(true);

//             foreach(GameObject go in flowerPrefabs.Values)
//             {
//                 Debug.Log($"Go in arObjects.Values: {go.name}");
//                 if(go.name != rTrackedImage.referenceImage.name)
//                 {
//                     go.SetActive(false);
//                 }
//             } 
//     }

//     void InstantiateFlower(ARTrackedImage image)
//     {
//         string name = image.referenceImage.name.Split('-')[0];
//         if (image.transform.childCount == 0)
//         {
//             //Debug.Log($"adding {name}");
//             GameObject flower = Instantiate(flowerPrefabs[name]);
//             // flower.transform.SetParent(image.transform, false);
//             flower.transform.position = image.transform.position;
//             flower.transform.rotation = image.transform.rotation;
//             flower.SetActive(true);
//         }
//         else
//         {
//             Debug.Log($"{name} already instantiated");
//         }
//     }

// }
