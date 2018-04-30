using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCreatures : MonoBehaviour {

    public GameObject[] creatures;
    public float spawnInterval = 0.3f;

    void Start()
    {
        InvokeRepeating("SpawnCreature", 1.0f, spawnInterval);
    }

    void SpawnCreature()
    {
        Vector3 position = new Vector3(Random.Range(-30.0F, 30.0F), 0, Random.Range(-30.0F, 30.0F));
        Instantiate(creatures[Random.Range(0, creatures.Length)], position, transform.rotation);
    }
}
