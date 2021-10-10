using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float moveSpeed = 3f;
    public string DERECHA = "derecha";
    public string IZQUIERDA = "izquierda";
    public bool jump;
    public string buttonPresed;
    public float cr = .05f;
    public Transform groundedcheck;
    public LayerMask ground;
    public bool grounded;
    public Transform keyholder;
    public Key followinkey;
    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.OverlapCircle(groundedcheck.position, cr, ground);

        if (Input.GetKey(KeyCode.D))
        {
            buttonPresed = DERECHA;
            transform.localScale = new Vector2(-1, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            buttonPresed = IZQUIERDA;
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            buttonPresed = null;
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        if (buttonPresed == DERECHA)
        {
            rb2D.velocity = new Vector2(moveSpeed, rb2D.velocity.y);
        }
        else if (buttonPresed == IZQUIERDA)
        {
            rb2D.velocity = new Vector2(-moveSpeed, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }

        if (jump)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, 10f);
            jump = false;
        }
    }
}
