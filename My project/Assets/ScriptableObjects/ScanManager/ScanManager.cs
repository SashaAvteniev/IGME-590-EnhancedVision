using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScanManager", menuName = "Scriptable Objects/ScanManager")]
public class ScanManager : ScriptableObject
{
    public List<string> scannablesTags;
    [Header("Lists all scanables")]
    [Tooltip("Keys are gameObject names")]
    public Dictionary<string, GameObject> scanablesList;

    public void Awake()
    {
        foreach(string tag in scannablesTags)
        {
            //GameObject[] objectsWithTag
        }
    }


}

