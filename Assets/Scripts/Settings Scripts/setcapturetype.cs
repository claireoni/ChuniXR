using UnityEngine;
using uWindowCapture;

// written by sabrina :)
public class setCapturetype : MonoBehaviour
{
    [SerializeField] private UwcWindowTexture uwcWindowTexture; 

    public void SetType(int index)
    {
        if (index == 0)
        {
            uwcWindowTexture.captureMode = CaptureMode.Auto;
        }
        else if (index == 1)
        {
            uwcWindowTexture.captureMode = CaptureMode.BitBlt;
        }
        else if (index == 2)
        {
            uwcWindowTexture.captureMode = CaptureMode.WindowsGraphicsCapture;
        }
        else if (index == 3)
        {
            uwcWindowTexture.captureMode = CaptureMode.PrintWindow;
        }
        else if (index == 4)
        {
            uwcWindowTexture.captureMode = CaptureMode.None;
        }

        Debug.Log("capture mode set to :) " + uwcWindowTexture.captureMode);
    }
}