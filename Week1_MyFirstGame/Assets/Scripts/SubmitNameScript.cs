using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SubmitNameScript : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI displayText;
    
    string welcomeText = "Hello, <name>! \n Welcome to Lily's first Unity Game!";
    string replaceWithName = "<name>";
    
    public void SubmitName()
    {
        Debug.Log("SubmitName was called with " + nameText.text);

        string[] nameStrings = nameText.text.Split(' ');
        
        string welcomeWithName = welcomeText.Replace(replaceWithName, nameStrings[0]);
        
        displayText.text = welcomeWithName + "\n";
    }
}