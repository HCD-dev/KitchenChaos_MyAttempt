using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInput : MonoBehaviour
{
    private PlayerInputAction PlayerInputActions;
    private void Awake()
    {
        PlayerInputActions = new PlayerInputAction();
        PlayerInputActions.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
       
            Vector2 inputVector = PlayerInputActions.Player.Move.ReadValue<Vector2>();
            inputVector = inputVector.normalized; // Giriþ vektörünü normalize et
        
       
        return inputVector;
    }





}
