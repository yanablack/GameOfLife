using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overlapshpere : MonoBehaviour {

    public Transform prefab;

    // Update is called once per frame
    void Update () {

        Collider[] neighboursInSphere = Physics.OverlapSphere(transform.position, 7);
        foreach(Collider neighbourInSphere in neighboursInSphere)
        {
            if (neighboursInSphere.Length > 3)
            {
                Destroy(gameObject);
                Debug.Log("creature should be destroyed");
            }
            else if (neighboursInSphere.Length < 2)
            {
                Destroy(gameObject);
                Debug.Log("creature should be destroyed");
            }
            else if (neighboursInSphere.Length == 3)
            {
                Instantiate(prefab);
                Debug.Log("a new creature should be created");
                //how to allocate the prefab the position of the deleted creature?
            }
            else if (neighboursInSphere.Length <= 2)
            {
                Instantiate(prefab);
                Debug.Log("a new creature should be created");
            }
            }
        }

    private void OnDrawGizmos()

    {
        Gizmos.DrawWireSphere(this.transform.position, 4f);
    }

}
