using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;

    //Untuk menggerakkan bola menggunakan WASD atau arrowkey
    float horizontal;
    float vertical;
    
    public float maxMoveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // menggerakkan bola menggunakan WASD atau arrowkey
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * maxMoveSpeed, vertical * maxMoveSpeed);
    }

}

