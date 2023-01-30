using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject inputField;
    public GameObject submitButton;
    public GameObject levelAButton;
    public GameObject levelBButton;
    public GameObject nextLevelButton;

    public void BeginQuest()
    {
        inputField.SetActive(false);
        submitButton.SetActive(false);
        levelAButton.SetActive(true);
        levelBButton.SetActive(true);
    }

    public void NextLevel()
    {
        nextLevelButton.SetActive(true);
    }
}
