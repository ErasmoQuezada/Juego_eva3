using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacielMovement : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        float Horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horizontal * Speed, rb.velocity.y);

        // Detección de salto solo si el personaje está en el suelo
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            Debug.Log("Saltando con fuerza: " + JumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detectar cuando el personaje toca el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Detectar cuando el personaje sale del suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
