using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 moveLimits = new Vector2(4f, 3f);

    private Vector2 input;

    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        // Move Ship
        Vector2 newPosition = transform.position + (Vector3)input * moveSpeed * Time.deltaTime;

        // Clamp movement within the screen limits
        newPosition.x = Mathf.Clamp(newPosition.x, -moveLimits.x, moveLimits.x);
        newPosition.y = Mathf.Clamp(newPosition.y, -moveLimits.y, moveLimits.y);

        transform.position = newPosition;

    }
}
