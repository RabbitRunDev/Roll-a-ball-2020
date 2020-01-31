using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        transform.Rotate(new Vector3(Random.Range(0.0f, 360.0f), (Random.Range(0.0f, 360.0f)), (Random.Range(0.0f, 360.0f))));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);   
    }
}
