
using UnityEngine;
using uWindowCapture;

//written by sabrina :)
public class SetUwcFrameRate : MonoBehaviour
{
    [SerializeField] private UwcWindowTexture uwcWindowTexture; 

    public void Setframerate(int index)
    {

        if (index == 0)
        {
            uwcWindowTexture.captureFrameRate = 120; 
        }
        else if (index == 1)
        {
            uwcWindowTexture.captureFrameRate = 60; 
        }

        Debug.Log("frame rate set to" + uwcWindowTexture.captureFrameRate);
    }
}