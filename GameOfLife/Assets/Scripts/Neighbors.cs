using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neighbors
{
    public const float Radius = 4f;
    public static int CountNeighbors(Transform transform)
    {
        int neighbors = 0;

        foreach (Collider col in Physics.OverlapSphere(transform.position, Radius))
        {
            if (col.transform == transform)
            {
                continue;
            }
            if (col.tag == "creature")
            {
                neighbors++;
            }
        }

        return neighbors;

    }
}
