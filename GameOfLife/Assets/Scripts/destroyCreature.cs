using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCreature : MonoBehaviour {

    private float spawnInterval = 0.3f;
    public float radius;

    void FixedUpdate () {
        if (Time.time < spawnInterval)
        {
            return;
        }

        foreach(Collider col in Physics.OverlapSphere(transform.position, radius))
        {
            if (col.tag == "creature")
            {
                Debug.Log("should be anothor creature created", gameObject);
                
                //neighbour++;
            }
            else //if (neighbour == 3)
            {
                DestroyImmediate(this);
            }
        }
        }

    private void OnDrawGizmos()

    {
        Gizmos.DrawWireSphere(this.transform.position, 4f);
    }

}
