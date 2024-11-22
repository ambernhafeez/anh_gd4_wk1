using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrackPosition : MonoBehaviour
{
    public Vector3 positionChange;
    public Vector3 rotateChange;
    public int moveNum;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += positionChange * Time.deltaTime;
        transform.Rotate (rotateChange);

        // function for moving back and forth on x axis
        
    }
}
