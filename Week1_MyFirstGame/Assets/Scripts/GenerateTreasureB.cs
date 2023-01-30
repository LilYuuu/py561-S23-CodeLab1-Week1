using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTreasureB : MonoBehaviour
{
    public GameObject TreasurePrefab;
    public float maxDistance;
    public float interval = 5;
    public float timeSinceLastGenerate;

    public PlayerControl script;
    
    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastGenerate = Time.time;
        
        Vector3 pos = new Vector3(Random.Range(-maxDistance, maxDistance), 0.5f,
            Random.Range(-maxDistance, maxDistance));
        Instantiate(TreasurePrefab, pos, transform.rotation, transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeSinceLastGenerate >= interval && script.count < 10)
        {
            Vector3 pos = new Vector3(Random.Range(-maxDistance, maxDistance), 0.5f,
                Random.Range(-maxDistance, maxDistance));
            Instantiate(TreasurePrefab, pos, transform.rotation, transform);
            timeSinceLastGenerate = Time.time;
        }
    }
}
