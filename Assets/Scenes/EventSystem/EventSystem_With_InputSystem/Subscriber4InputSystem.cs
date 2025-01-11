using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

/// <summary>
/// 当键盘按下`键时，输出"Subscriber() invoked"
/// </summary>
public class Subscriber4InputSystem : MonoBehaviour
{
    private Controls4EventSystem _controls4EventSystem;
    private InputAction _inputAction;
    private UnityEvent _unityEvent = new UnityEvent();

    private void Awake()
    {
        _controls4EventSystem = new Controls4EventSystem();
    }

    private void OnEnable()
    {
        _inputAction = _controls4EventSystem.FindAction("KeyActions");
        _inputAction.Enable();
    }

    private void OnDisable()
    {
        _inputAction.Disable();
    }

    void Start()
    {
        _unityEvent.AddListener(Subscriber);

        _inputAction.started += context => _unityEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Subscriber()
    {
        Debug.Log("Subscriber() invoked");
    }
}
