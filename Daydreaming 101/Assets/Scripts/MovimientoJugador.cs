using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private Rigidbody2D rb2D;

    public float moveSpeed = 3f;
    public float jumpSpeed = 6f;

    public string DERECHA = "derecha";
    public string IZQUIERDA = "izquierda";

    public string buttonPressed;

    public bool jump;

    //----variables para checar si estamos tocando el piso
    public bool grounded;
    public Transform groundCheck;
    public LayerMask ground;
    public float circleRadius = .05f;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, circleRadius, ground);

        if (Input.GetKey(KeyCode.D))
        {
            print(DERECHA);
            buttonPressed = DERECHA;
            transform.localScale = new Vector2(1, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print(IZQUIERDA);
            buttonPressed = IZQUIERDA;
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            print("idle");
            buttonPressed = null;
        }

        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {
        if (buttonPressed == DERECHA)
        {
            rb2D.velocity = new Vector2(moveSpeed, rb2D.velocity.y);
        }
        else if (buttonPressed == IZQUIERDA)
        {
            rb2D.velocity = new Vector2(-moveSpeed, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (jump)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            jump = false;
        }
    }
}
