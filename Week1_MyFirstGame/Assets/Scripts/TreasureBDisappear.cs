using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TreasureBDisappear : MonoBehaviour
{
    float age = 4.4f;
    private float timeGenerated;
    
    // Start is called before the first frame update
    void Start()
    {
        timeGenerated = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeGenerated >= age)
        {
            Destroy(gameObject);
        }
    }
}
