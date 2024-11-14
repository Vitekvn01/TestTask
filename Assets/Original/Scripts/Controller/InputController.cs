using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour, IService, IInputController
{
    void Awake()
    {
        ServiceLocator.RegisterService<IInputController>(this);
    }
    public float GetAxisHorizontal()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public float GetAxisVertical()
    {
        return Input.GetAxisRaw("Vertical");
    }

    public float GetAxisMouseY()
    {
        return Input.GetAxis("Mouse Y");
    }

    public float GetAxisMouseX()
    {
        return Input.GetAxis("Mouse X");
    }

    public bool IsButtonHold(string buttonName)
    {
        return Input.GetButton(buttonName);
    }

    // Start is called before the first frame update



}
