using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPinSpawns : MonoBehaviour
{
    public GameObject[] BowlingPinPrefab;
    public float spawnRangeX = 2;
    private float spawnMinZ = 65;
    private float spawnMaxZ = 75;
    private float startDelay = 0;
    private float spawnInterval = 0.0001f;
    private int maxPins = 10;
    private int pinsSpawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPin", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomPin()
    {
        if (pinsSpawned < maxPins)
        {
            int PinIndex = Random.Range(0, BowlingPinPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(spawnMinZ, spawnMaxZ));
            Instantiate(BowlingPinPrefab[PinIndex], spawnPos, BowlingPinPrefab[PinIndex].transform.rotation);
            pinsSpawned++;
        }
    }
}
