using UnityEngine;

public class MaterialColorChanger : MonoBehaviour
{
    public Renderer targetRenderer; // Assign the Renderer component in the Inspector
    public Color unpressedColor = new Color(1.0f, 0.5f, 0.0f); // Orange
    public Color pressedColor = new Color(1.0f, 0.0f, 1.0f); // Magenta

    private void Start()
    {
        if (targetRenderer != null)
        {
            targetRenderer.material.color = unpressedColor;
        }
        else
        {
            Debug.LogError("No Renderer component assigned to targetRenderer.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (targetRenderer != null)
        {
            targetRenderer.material.color = pressedColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (targetRenderer != null)
        {
            targetRenderer.material.color = unpressedColor;
        }
    }
}