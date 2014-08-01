using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Camera))]
public class TargetCamera : MonoBehaviour
{
    #region exposed
    
    public GameObject Target;
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////
    
    #region public
    
    public void RotateAroundTarget(float angle)
    {
        transform.RotateAround(Target.transform.position, Vector3.up, angle);
    }
    
    #endregion
}
