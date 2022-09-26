using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;


[System.Serializable]
public class FlowerTestPrefabDictionary : SerializableDictionaryBase<string, GameObject> { }


public class MainModeNew : MonoBehaviour
{
    [SerializeField] FlowerTestPrefabDictionary flowerPrefabsTest;
    [SerializeField] ARTrackedImageManager imageManager;

    private void OnEnable() 
    {
        UIController.ShowUI("Main");
        foreach (ARTrackedImage image in imageManager.trackables)
        {
            InstantiateFlowerTest(image);
        }
    }

    void InstantiateFlowerTest(ARTrackedImage image)
    {
        string name = image.referenceImage.name.Split('-')[0];
        if (image.transform.childCount == 0)
        {
            GameObject flower = Instantiate(flowerPrefabsTest[name]);
            flower.transform.SetParent(image.transform, false);
        }
        else
        {
            Debug.Log($"{name} already instantiated");
        }
    }
}
