using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Controller movementController;
    private Rigidbody2D movementRigidbody;

    public float speed = 5f;
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<Controller>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;

        movementRigidbody.velocity = direction;
    }
}
