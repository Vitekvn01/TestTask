using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLogic : MonoBehaviour
{
    private float _rotationSpeed;
    private float _mouseSensitivity;

    private readonly Transform _objectTransform;
    private readonly Transform _cameraTransform;

    private float _verticalRotation = 0f;
    private readonly float _minVerticalAngle = -90f;
    private readonly float _maxVerticalAngle = 90f;

    private IInputController _inputController;

    public RotationLogic(Transform objectTransform, Transform cameraTransform, IInputController inputController, float speed, float sensitivity)
    {
        _rotationSpeed = speed;
        _mouseSensitivity = sensitivity;
        _objectTransform = objectTransform;
        _cameraTransform = cameraTransform;
        _inputController = inputController;
    }

    public void Update()
    {
        float dirRotX = _inputController.GetAxisMouseX();
       RotateBody(dirRotX, _mouseSensitivity, _rotationSpeed);


        float dirRotY = _inputController.GetAxisMouseY();
        RotateCamera(dirRotY, _mouseSensitivity, _rotationSpeed);

    }
    public void RotateBody(float dirRotX, float sensitivity, float rotSpeed)
    {
        _objectTransform.Rotate(Vector3.up * dirRotX * sensitivity * rotSpeed);
    }

    public void RotateCamera(float dirRotY, float sensitivity, float rotSpeed)
    {

        _verticalRotation -= dirRotY * sensitivity * rotSpeed;
        _verticalRotation = Mathf.Clamp(_verticalRotation, _minVerticalAngle, _maxVerticalAngle);

        _cameraTransform.localRotation = Quaternion.Euler(_verticalRotation, 0f, 0f);
    }
}
