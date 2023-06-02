using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnBehaviour : MonoBehaviour
{
    [SerializeField] PlayerInput _input;

    [Header("Player Turn")]
    [SerializeField] private float _turnSpeed;

    void Update()
    {
        RotatePlayer();
    }

    void RotatePlayer()
    { 
        // Player turn Movement
        transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime * _input.mouseX);
    }
}
