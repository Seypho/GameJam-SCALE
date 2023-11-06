using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class S1PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;
    Vector2 rawMovementVector;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void OnMove(InputValue value)
    {
        rawMovementVector = value.Get<Vector2>();
    }

    void Move()
    {
        Vector2 delta = rawMovementVector * moveSpeed * Time.deltaTime;
        rb.velocity = delta;
    }
}
