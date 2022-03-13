using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0f, 20f)] public float runSpeed;

    Rigidbody2D rb;
    float x, y;
    const float moveLimiter = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 && y != 0) 
        {
            x *= moveLimiter;
            y *= moveLimiter;
        }

        rb.velocity = new Vector2(x * runSpeed, y * runSpeed);
    }
}
