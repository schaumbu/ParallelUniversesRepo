using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerInput _playerInput;
    // Start is called before the first frame update
    void Start()
    {
        _playerInput = new PlayerInput();
        _playerInput.Movement.WalkLeft.performed += btn => walkLeft();
        _playerInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void walkLeft()
    {
        
    }
}
