using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))] 
public class PlayerInput : MonoBehaviour
{
    private float _horizontalDirection;
    private float _verticalDirection;
    private bool _plantTheBomb;

    //For keyboard input
    void Update()
    {
        /*
        _horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HORIZONTAL_AXIS);
        _verticalDirection = Input.GetAxisRaw(GlobalStringVars.VERTICAL_AXIS);
        _plantTheBomb = Input.GetButtonDown(GlobalStringVars.PLANTTHEBOMB);
        */
    }

    public float GetHorizontatalAxisInput()
    {
        return _horizontalDirection;
    }

    public float GetVerticalAxisInput()
    {
        return _verticalDirection;
    }

    public bool GetPlantTheBombInput()
    {
        return _plantTheBomb;
    }

    public void HorisontalDirection(int horizontal)
    {
        _verticalDirection = 0;
        _horizontalDirection = horizontal;
    }
    
    public void VerticalDirection(int vertical)
    {
        _horizontalDirection = 0;
        _verticalDirection = vertical;
    }
}
