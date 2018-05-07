using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCreature : MonoBehaviour {

    public float destroyInterval = 0.5f;
    private float timer;

    void Update()
    {
        DestroyPrefab();
    }

    void DestroyPrefab()
    {
        timer += Time.deltaTime;

        if (timer < destroyInterval)
        {
            //Debug.Log(timer);
            return;
        }

        timer = 0;

        int cn = Neighbors.CountNeighbors(transform);
        Debug.Log(cn);

        if ((cn < 2) || (cn > 3))
        {
            Debug.Log("destroy creature");
            Destroy(this.gameObject);
        }
    }
}        
 
