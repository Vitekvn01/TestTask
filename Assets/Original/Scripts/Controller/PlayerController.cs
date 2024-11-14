using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IService
{
    private IInputController _inputController;
    private MovementLogic _movementLogic;
    private RotationLogic _rotationLogic;
    private InteractionLogic _interactionLogic;
    private Player _player3DView;

    private void Awake()
    {
        ServiceLocator.RegisterService<PlayerController>(this);
    }

    void Update()
    {
        if (_player3DView != null)
        {
            _movementLogic.Update();

            _rotationLogic.Update();

            _interactionLogic.Update();
        }
    }

    public void Init(Player playerView)
    {
        SetPlayerView(playerView);
        _inputController = ServiceLocator.GetService<IInputController>();
        _movementLogic = new MovementLogic(playerView.gameObject, _inputController, playerView.MoveSpeed);
        _rotationLogic = new RotationLogic(playerView.gameObject.transform, playerView.Camera.gameObject.transform, playerView.RotationSpeed, playerView.MouseSensitivity, _inputController);
        _interactionLogic = new InteractionLogic(playerView.Camera, _inputController);
    }

    public void SetPlayerView(Player playerView)
    {
        _player3DView = playerView;
    }


}
