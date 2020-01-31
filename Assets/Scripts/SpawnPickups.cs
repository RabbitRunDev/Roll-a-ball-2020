using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{
    public int numObjects = 10;
    public GameObject prefab;
    public float radius;

    private float angleHandler;
    

    void Start()
    {
        Vector3 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            Vector3 pos = Circle(center, radius);
            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
            Instantiate(prefab, pos, rot);
        }
    }

    Vector3 Circle(Vector3 center, float radius)
    {
        float ang = 360 / numObjects;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(angleHandler * Mathf.Deg2Rad);
        pos.y = center.y;
        pos.z = center.z + radius * Mathf.Cos(angleHandler * Mathf.Deg2Rad);
        angleHandler = angleHandler + ang;
        return pos;
    }
}
