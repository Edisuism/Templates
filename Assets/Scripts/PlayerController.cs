using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// If you require animations for your character, please refer to the following link
// https://youtu.be/whzomFgjT50?t=550


public class PlayerController : MonoBehaviour
{
    [Header("Speed Settings")]
    public int health;

    [Header("Speed Settings")]
    [SerializeField] private float baseSpeed;

    // Don't change these
    private Vector2 moveDirection;
    private Vector2 translation;
    private float _speed;
    private Vector2 _input;

    private void Start()
    {

    }

    private void Update()
    {
        // Calculate current movement speed.
        _speed = baseSpeed;

        // Movement
        UpdateInput();
        moveDirection = _input.normalized;
        translation = moveDirection * (_speed * Time.deltaTime);
        transform.Translate(translation);
    }


    private void UpdateInput()
    {
        // Get input
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetAxisRaw("Vertical");
    }

   
}
