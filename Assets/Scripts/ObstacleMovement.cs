using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float movementSpeed = 0.1f;
    void FixedUpdate()
    {
        Vector2 newPosition = new Vector2(transform.position.x - movementSpeed, transform.position.y);
        transform.position = Vector2.Lerp(transform.position, newPosition, 0.1f);
    }
}
