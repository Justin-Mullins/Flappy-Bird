using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    // Update is called at a fixed time.
    void FixedUpdate()
    {
        // Lerp does a smooth motion from current position to a new positon - movement speed.
        transform.position = Vector2.Lerp(transform.position, -new Vector2(transform.position.x - moveSpeed, transform.position.y), 0.1f);
    }
}
