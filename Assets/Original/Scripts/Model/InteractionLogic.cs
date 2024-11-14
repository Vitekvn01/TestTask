using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionLogic
{
    private float _pickupRange = 2f;
    private Camera _playerCamera;
    private IInputController _inputController;
    public InteractionLogic(Camera camera, IInputController inputController)
    {
        _playerCamera = camera;
        _inputController = inputController;
    }

    public void Update()
    {
        if (_inputController.IsButtonHold("Pickup"))
        {
            TryInteractiveItem();
        }
    }


    public void TryInteractiveItem()
    {
        RaycastHit hit;
        Ray ray = _playerCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(ray, out hit, _pickupRange))
        {
            IInteractivuble interactive = hit.collider.GetComponent<IInteractivuble>();
            if (interactive != null)
            {
                interactive.Interactive();
                Debug.Log("Interactive");

            }
            else
            {
                Debug.Log("Null");
            }
        }
    }
}
