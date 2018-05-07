using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCreature : MonoBehaviour {

    private float spawnInterval = 0.5f;
    public float radius;
    private float timer;

    void Update()
        {
        destroyPrefab();
        }

    void destroyPrefab()
        {

        timer += Time.deltaTime;

        if (timer < spawnInterval)
            {
            Debug.Log("interval hasn't passed yet");
            timer = 0;
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
                Destroy(this.gameObject);
                }
            }
        }

}
