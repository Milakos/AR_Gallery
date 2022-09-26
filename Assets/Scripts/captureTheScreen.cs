using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class captureTheScreen : MonoBehaviour
{
    public void screenCapture()
    {
        ScreenCapture.CaptureScreenshot("myGallery.png");
    }
}
