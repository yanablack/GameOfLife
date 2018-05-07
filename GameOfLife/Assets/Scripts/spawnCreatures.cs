using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreatures : MonoBehaviour {

    public Transform prefab;
    public float spawnInterval = 0.5f;
    private int number = 0;

    void Start()
    {
        InvokeRepeating("SpawnCreature", spawnInterval, spawnInterval);
    }

    void SpawnCreature()
    {
        Vector3 position = new Vector3(Random.Range(-30.0F, 30.0F), 0, Random.Range(-30.0F, 30.0F));
        Transform newCreature = Instantiate(prefab, position, Quaternion.identity);
        newCreature.name = "Creature " + number++;
        Debug.Log(newCreature.name);
    }
}
