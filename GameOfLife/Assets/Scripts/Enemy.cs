using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

    // Update is called once per frame
	void Update () {

        Collider [] hits = Physics.OverlapSphere(transform.position, 7);
        foreach (Collider hit in hits)
        {
            if (hit.tag == "Player")
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, step);
            }
        }
        
	}

    private void OnDrawGizmos()

    {
        Gizmos.DrawWireSphere(this.transform.position, 5f);
    }
}
