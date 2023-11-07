using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class S0PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveDistance = 5f;
    Vector2 minBounds;
    Vector2 maxBounds;
    [SerializeField] float paddingLeft = 1f;
    [SerializeField] float paddingRight = 1f;
    [SerializeField] float paddingTop = 1f;
    [SerializeField] float paddingBottom = 1f;

    Vector3 rawInput;

    void Awake()
    {
        InitBounds();
    }

    void InitBounds()
    {
        Camera mainCamera = Camera.main;
        minBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maxBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));
        Debug.Log(minBounds);
        Debug.Log(maxBounds);
    }

    void Move()
    {
        
    }
    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
        if (Mathf.Abs(rawInput.x) == 1 || Mathf.Abs(rawInput.y) == 1)
        {
            Vector3 newPos = new Vector2();
            Vector2 delta = rawInput * moveDistance;
            newPos.x = Mathf.Clamp(transform.position.x + delta.x, minBounds.x + paddingLeft, maxBounds.x - paddingRight);
            newPos.y = Mathf.Clamp(transform.position.y + delta.y, minBounds.y + paddingBottom, maxBounds.y - paddingTop);

            Debug.Log(newPos);
            transform.position = newPos;
        }
    }
}
