using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class S1PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 5f;

    Vector3 rawInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 newPos = new Vector2();
        Vector3 delta = rawInput * moveSpeed;

        rb.velocity = new Vector2(delta.x, rb.velocityY);
    }
    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
    
    }
}
