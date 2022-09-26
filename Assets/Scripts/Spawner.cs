using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
   
    public GameObject[] gameObjectToSpawn;
    private Simple simple;
    private Touch touch;
    public int chooseObj = 0;
    // Start is called before the first frame update
    void Start()
    {
        simple = FindObjectOfType<Simple>();
    }

    // Update is called once per frame
    void Update()
    {
     

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                var touchPosition = touch.position;
                bool isUI = touchPosition.isPOintOverUIObject();

                if (isUI)
                {
                    return;
                }
                if (!isUI)
                {
                    GameObject obj = Instantiate(gameObjectToSpawn[chooseObj], simple.transform.position, Quaternion.identity);
                }
            }
        }
    }

    public void ChangeNUmber()
    {
        chooseObj += 1;
        
        if (chooseObj >= gameObjectToSpawn.Length)
        {
            chooseObj = 0;
        }
    }
}
