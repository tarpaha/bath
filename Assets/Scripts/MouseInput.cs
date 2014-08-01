using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseInput : MonoBehaviour
{
    #region public
    
    public Vector2 Delta { get { return _delta; } }
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////
    
    #region MonoBehaviour

    private void Update()
    {
        if(!_mouseDown)
        {
            if(Input.GetMouseButtonDown(0))
            {
                _mouseDown = true;
                _lastPos = Input.mousePosition;
            }
        }
        else
        {
            _delta = Input.mousePosition - _lastPos;
            _lastPos = Input.mousePosition;
        
            if(Input.GetMouseButtonUp(0))
            {
                _mouseDown = false;
                _delta = Vector2.zero;
            }
        }
    }

    #endregion
    
    ////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////
    
    #region data
    
    private bool _mouseDown;
    
    private Vector3 _lastPos;
    private Vector2 _delta;
    
    #endregion
}
