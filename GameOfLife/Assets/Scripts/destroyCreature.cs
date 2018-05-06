using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCreature : MonoBehaviour {

    private float spawnInterval = 0.5f;
    public float radius;

    void Update () {

        spawnInterval -= Time.deltaTime;
        if (spawnInterval >= 0)
            {
            Debug.Log("interval hasn't passed yet");
            spawnInterval = 0.5f;
            return;
            }

        foreach (Collider col in Physics.OverlapSphere(transform.position, radius))
            {
            int neighbor = 0;
            if (col.tag == "creature")
                { 
                neighbor++;
                }
            else if (neighbor == 3)
                {
                Debug.Log("destroy creature");
                Destroy(gameObject);
                }
            }
        }

}
