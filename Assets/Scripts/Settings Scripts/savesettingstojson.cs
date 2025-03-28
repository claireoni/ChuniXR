using System;
using System.IO;
using UnityEngine;

// written by sabrina and the lemonade in her fridge with a liiitle help

[Serializable]
public class Settingsdata
{
    public int captureMode;
    public int captureFramerate;
    public int turnStyle;
}

public static class Settingsfile
{
    private static string filePath = Application.persistentDataPath + "/settings.json";

    public static void SaveSettings(Settingsdata settings)
    {
        string json = JsonUtility.ToJson(settings, true);
        File.WriteAllText(filePath, json);
        Debug.Log("Settings saved to " + filePath);
    }

    public static Settingsdata Loadsettings()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonUtility.FromJson<Settingsdata>(json);
        }
        else
        {
            Debug.Log("no settings found, using default.");
            return new Settingsdata(); 
        }
    }
}