using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemScript : MonoBehaviour
{
    private PlayerInputActions _playerInputActions;
    private InputAction _movement;


    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        _movement = _playerInputActions.Player.Movement;
        _movement.Enable();

        _movement.performed += DoMove;
    }

    private void DoMove(InputAction.CallbackContext obj)
    {
        Debug.Log("Move!");
    }

    private void OnDisable()
    {
        _movement.Disable();
    }

    private void FixedUpdate()
    {
        Debug.LogFormat("Movement values:{0}", _movement.ReadValue<Vector2>());
    }
}