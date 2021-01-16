using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        var rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1.0f, 1.0f).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
