using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;

    public float speed = 3;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var velocity = new Vector2(0f, 0f);
        if (Input.GetKey(up))
        {
            velocity = new Vector2(0f, speed);
        }

        if (Input.GetKey(down))
        {
            velocity = new Vector2(0f, -speed);
        }
        rb.velocity = velocity;
    }
}
