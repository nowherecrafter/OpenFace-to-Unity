using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.Json;
using System.Text.Json.Serialization;
using Palmmedia.ReportGenerator.Core.Common;
using System.IO;
using System.Threading.Tasks;
using Unity.VisualScripting;
using System;
using UnityEditor;

public static class JsonImporter
{
    //weaponDatabase = JsonUtility.FromJson<WeaponListObject>(@"Assets\JSON Data\Weapons");

    public static FeedbackList ParseJSON()
    {
        if (File.Exists(@"Assets\Feedback\FeedbackData.json"))
        {
            
            string jsonString = File.ReadAllText(@"Assets\Feedback\FeedbackData.json");
            FeedbackList import = JsonUtility.FromJson<FeedbackList>(jsonString);

            return import;
        }
        else
        {
            Debug.LogError("JSON file not found!");
            return null;
        }

        

        
    }

}
