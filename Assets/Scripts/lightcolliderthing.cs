using UnityEngine;

public class LightColorChangerCollider : MonoBehaviour
{
    public Light targetLight; // Assign your Light component in the Inspector
    public Color untouchedColor = new Color(1.0f, 0.5f, 0.0f); // Orange
    public Color touchedColor = new Color(1.0f, 0.0f, 1.0f); // Magenta

    private void Start()
    {
        if (targetLight != null)
        {
            targetLight.color = untouchedColor;
        }
        else
        {
            Debug.LogError("No Light component assigned to targetLight.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetLight != null)
        {
            targetLight.color = touchedColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (targetLight != null)
        {
            targetLight.color = untouchedColor;
        }
    }
}
