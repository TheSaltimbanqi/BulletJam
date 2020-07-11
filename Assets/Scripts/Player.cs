using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    public float minSpeed = 1f;

    public float thrust;
    public float turnThurst;

    private float thrustInput;
    private float turnInput;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        thrustInput = 0.5f;//1 sola velocidad
        turnInput = (Input.GetAxis("Horizontal"));
    }

    private void FixedUpdate()
    {
        rb2d.AddRelativeForce(Vector2.up * thrustInput);
        rb2d.AddTorque(-turnInput);
    }
}
