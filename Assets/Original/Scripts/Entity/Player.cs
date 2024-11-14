using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera Camera;
    public float MoveSpeed;
    public float RotationSpeed;
    public float MouseSensitivity;

    private PlayerController _playerController;
    private Inventory _inventory;

    private void Start()
    {
        _playerController = ServiceLocator.GetService<PlayerController>();
        _playerController.Init(this);
    }


}
