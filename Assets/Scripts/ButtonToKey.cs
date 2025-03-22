using System;
using System.Runtime.InteropServices;
using UnityEngine;
using WindowsInput.Native;

public class ButtonToKey : MonoBehaviour
{
    public Renderer targetRenderer; // Assign the Renderer component in the Inspector
    public Color unpressedColor = new Color(1.0f, 0.5f, 0.0f); // Orange
    public Color pressedColor = new Color(1.0f, 0.0f, 1.0f); // Magenta

    [DllImport("user32.dll")]
    public static extern uint MapVirtualKey(uint uCode, uint uMapType);

    [DllImport("user32.dll")]
    static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

    public VirtualKeyCode keyToPress;
    private int _insideColliderCount = 0;

    private void Start()
    {
        if (targetRenderer != null)
        {
            targetRenderer.material.color = unpressedColor;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only trigger if the object has the Player tag
        if (other.CompareTag("Player"))
        {
            _insideColliderCount += 1;
            keybd_event(System.Convert.ToByte(keyToPress), (byte)MapVirtualKey((uint)keyToPress, 0), 0, UIntPtr.Zero);
            Debug.Log("Key Pressed! Player entered the collider.");

            if (targetRenderer != null)
            {
                targetRenderer.material.color = pressedColor;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _insideColliderCount -= 1;
            _insideColliderCount = Mathf.Max(0, _insideColliderCount);
            if (_insideColliderCount == 0)
            {
                keybd_event(System.Convert.ToByte(keyToPress), (byte)MapVirtualKey((uint)keyToPress, 0), 2, UIntPtr.Zero);
                Debug.Log("Key Released! Player exited the collider.");
            }

            if (targetRenderer != null)
            {
                targetRenderer.material.color = unpressedColor;
            }
        }
    }
}