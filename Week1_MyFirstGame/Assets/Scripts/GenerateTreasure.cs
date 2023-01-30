using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTreasure : MonoBehaviour
{
    public GameObject TreasurePrefab;
    public float maxDistance;
    public int nbTreasure = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        for (float i = 0; i < nbTreasure; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-maxDistance, maxDistance), 0.5f,
                Random.Range(-maxDistance, maxDistance));
            Instantiate(TreasurePrefab, pos, transform.rotation, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
