using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DeedJournal : MonoBehaviour
{
     List<string> deedLog = new List<string>();

    public void AddDeed(string deedName, int moralPoint)
    {
        deedLog.Add(deedName + moralPoint);
    }

    private void Update()
    {
        if (Keyboard.current.jKey.wasPressedThisFrame)
        {
            foreach (string deedName in deedLog)
            {
                Debug.Log(deedName);
            }
        }
    }
}
