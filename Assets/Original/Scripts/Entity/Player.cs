using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float _moveSpeed = 100f;
    [SerializeField] private float _rotationSpeed = 100f;
    [SerializeField] private float _mouseSensitivity = 1f;

    private void Awake()
    {
        
    }
}
