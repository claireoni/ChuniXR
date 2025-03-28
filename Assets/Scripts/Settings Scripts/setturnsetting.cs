using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

// Written by Sabrina :)
public class SetTurnType : MonoBehaviour
{
    [SerializeField] private SnapTurnProvider snapTurn;
    [SerializeField] private ContinuousTurnProvider continuousTurn;
    private Settingsdata settings;

    void Start()
    {
        settings = Settingsfile.Loadsettings();
        ApplySettings();
    }

    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if (index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }

        settings.turnStyle = index;
        Settingsfile.SaveSettings(settings);
        Debug.Log("Turn style set to: " + settings.turnStyle);
    }

    private void ApplySettings()
    {
        if (settings.turnStyle == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
    }
}