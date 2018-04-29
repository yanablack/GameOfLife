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
                Destroy(gameObject, 5);
                Debug.Log("creature should be destroyed");
            }
            else if (neighboursInSphere.Length < 2)
            {
                Destroy(gameObject, 5);
                Debug.Log("creature should be destroyed");
            }
            else if (neighboursInSphere.Length <= 2)
            {
                if (gameObject)return;
                Debug.Log("the creature should live");
            }
            else if (neighboursInSphere.Length == 3)
            {
                Instantiate(prefab, this.transform.position, this.transform.rotation);
                Debug.Log("a new creature should be created");
                //how to allocate the prefab the position of the deleted creature?
            }
        }
        }

    private void OnDrawGizmos()

    {
        Gizmos.DrawWireSphere(this.transform.position, 4f);
    }

}
