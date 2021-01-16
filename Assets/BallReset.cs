using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public void Reset()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(Vector2.zero);
    }
}
