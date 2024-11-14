using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputController
{
    public float GetAxisVertical();

    public float GetAxisHorizontal();

    public float GetAxisMouseY();

    public float GetAxisMouseX();

    public bool IsButtonHold(string buttonName);
}
