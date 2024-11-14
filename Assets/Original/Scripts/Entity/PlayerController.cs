using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private IInputController _inputController;
    private MovementLogic _movementLogic;
    private RotationLogic _rotationLogic;


    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float _moveSpeed = 100f;
    [SerializeField] private float _rotationSpeed = 100f;
    [SerializeField] private float _mouseSensitivity = 1f;

    private void Start()
    {
        _inputController = ServiceLocator.GetService<IInputController>();
        _movementLogic = new MovementLogic(gameObject, _inputController, _moveSpeed);
        _rotationLogic = new RotationLogic(gameObject.transform, cameraTransform, _inputController, _moveSpeed, _mouseSensitivity);
    }


    // Update is called once per frame
    void Update()
    {
        _movementLogic.Update();

        _rotationLogic.Update();
    }
}
