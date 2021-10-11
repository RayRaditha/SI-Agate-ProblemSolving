using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMouseMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;

    //Untuk menggerakkan bola dengan mouse
    public float maxMoveSpeed = 10f;

    //Agar gerakan bola lebih smooth
    public float smoothTime = 0.4f;

    Vector2 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // menggerakkan bola mengikuti kursor mouse
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);

    }
}
