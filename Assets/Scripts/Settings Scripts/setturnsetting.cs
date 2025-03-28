using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

// written by sabrina
public class SetTurnType : MonoBehaviour
{
    [SerializeField] private SnapTurnProvider snapTurn;
    [SerializeField] private ContinuousTurnProvider continuousTurn;
    
    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if(index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
        
    }
    
}
