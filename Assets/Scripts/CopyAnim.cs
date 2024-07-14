using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyAnim : MonoBehaviour
{
    
    public Transform target;
    public ConfigurableJoint joint;

    private Quaternion startingRotation;
    void Start()
    {
        startingRotation = transform.rotation;
    }

    
    void Update()
    {
        joint.SetTargetRotationLocal(target.rotation, startingRotation);
    }
}
