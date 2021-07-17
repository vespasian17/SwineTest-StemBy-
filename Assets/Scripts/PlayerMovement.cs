using UnityEngine;

[RequireComponent(typeof(MovementLogic))]
public class PlayerMovement : MonoBehaviour, IMovable
{
    private PlayerInput _playerInput;
    private MovementLogic _movementLogic;

    private void Awake()
    {
        _movementLogic = GetComponent<MovementLogic>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        _movementLogic.Move(_playerInput.GetHorizontatalAxisInput(), _playerInput.GetVerticalAxisInput());
    }

    public float GetHorizontalAxis()
    {
        return _playerInput.GetHorizontatalAxisInput();
    }

    public float GetVerticalAxis()
    {
        return _playerInput.GetVerticalAxisInput();
    }
}
