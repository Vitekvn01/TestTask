using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLogic
{


    private GameObject _object;
    private Rigidbody _rb;
    private IInputController _inputController;
    private float _moveSpeed;

    public MovementLogic(GameObject playerObject, IInputController controller, float speed)
    {
        _object = playerObject;
        _rb = playerObject.GetComponent<Rigidbody>();
        _inputController = controller;
        _moveSpeed = speed;
    }

    public void Update()
    {
        float dirX = _inputController.GetAxisHorizontal();
        float dirZ = _inputController.GetAxisVertical();
        bool isSpeedUp = _inputController.IsButtonHold("Run");
        Movement(dirZ, dirX, _moveSpeed, isSpeedUp);
    }
    private void Movement(float dirZ, float dirX, float speed, bool isSpeedUp)
    {
        Vector3 gravity = new Vector3(0, _rb.velocity.y, 0);
        _rb.velocity = gravity + CalculateDirection(dirZ, dirX) * speed * GetSpeedMultiplier(isSpeedUp) * Time.fixedDeltaTime;
    }


    private Vector3 CalculateDirection(float inputZ, float inputX)
    {
        return _object.transform.forward * inputZ + _object.transform.right * inputX;
    }

    private float GetSpeedMultiplier(bool isSpeedUp)
    {
        return isSpeedUp ? 2f : 1f;
    }
}
