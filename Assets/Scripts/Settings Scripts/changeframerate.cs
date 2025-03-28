using UnityEngine;
using uWindowCapture;

// written by sabrina :)
public class SetUwcFrameRate : MonoBehaviour
{
    [SerializeField] private UwcWindowTexture uwcWindowTexture; 
    private Settingsdata settings; 

    void Start()
    {
        settings = Settingsfile.Loadsettings(); 
        Setframerate(settings.captureFramerate); 
    }

    public void Setframerate(int index)
    {
        if (uwcWindowTexture == null) return;

        if (index == 0)
        {
            uwcWindowTexture.captureFrameRate = 120;
        }
        else if (index == 1)
        {
            uwcWindowTexture.captureFrameRate = 60;
        }

        settings.captureFramerate = index; 
        Settingsfile.SaveSettings(settings); 

        Debug.Log("frame rate set to " + uwcWindowTexture.captureFrameRate);
    }
}