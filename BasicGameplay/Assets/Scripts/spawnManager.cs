using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    private float spawnRangeX = 6;
    private float spawnRangeZ = 10;

    private float startdelay = 2;
    private float spawnInterval = 1.5f;

    public GameObject[] barrelPrefab;
    //public int barrelIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startdelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
         int barrelIndex = Random.Range(0, barrelPrefab.Length);
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
         Instantiate(barrelPrefab[barrelIndex], spawnPos, barrelPrefab[barrelIndex].transform.rotation);
    }
}
