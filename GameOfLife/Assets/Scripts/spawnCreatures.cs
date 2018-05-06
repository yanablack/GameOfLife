using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCreatures : MonoBehaviour {

    public Transform prefab;
    public float spawnInterval = 0.5f;

    void Start()
    {
        InvokeRepeating("SpawnCreature", 1.0f, spawnInterval);
    }

    void SpawnCreature()
    {
        Vector3 position = new Vector3(Random.Range(-30.0F, 30.0F), 0, Random.Range(-30.0F, 30.0F));
        Instantiate(prefab, position, Quaternion.identity);
    }
}
