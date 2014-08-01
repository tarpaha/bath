using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rotator : MonoBehaviour
{
    #region exposed
    
    public MouseInput Input;
    public TargetCamera Camera;
    
    public float RotationSpeed = 1.0f;
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////
    
    #region MonoBehaviour

    private void Update()
    {
        Camera.RotateAroundTarget(Input.Delta.x * RotationSpeed);
    }

    #endregion
}
