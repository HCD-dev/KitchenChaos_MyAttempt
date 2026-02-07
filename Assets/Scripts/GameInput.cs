using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameInput : MonoBehaviour
{
    public event EventHandler OnInteractAction;

    private PlayerInputAction PlayerInputActions;
    private void Awake()
    {
        PlayerInputActions = new PlayerInputAction();
        PlayerInputActions.Player.Enable();
        PlayerInputActions.Player.Interact.performed += Interact_performed;
    }
    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
         
          OnInteractAction?.Invoke(this,EventArgs.Empty);
    }
    public Vector2 GetMovementVectorNormalized()
    {
       
            Vector2 inputVector = PlayerInputActions.Player.Move.ReadValue<Vector2>();
            inputVector = inputVector.normalized; // Giriþ vektörünü normalize et
        
       
        return inputVector;
    }





}
