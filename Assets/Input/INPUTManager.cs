using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class INPUTManager : MonoBehaviour
{
    public static Vector2 Movement;

    private PlayerInput playerInput;
    private InputAction moveAction;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Movement"];
    }

    private void Update()
    {
        Movement = moveAction.ReadValue<Vector2>();
    }
}
