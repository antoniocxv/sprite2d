using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad = 5f;
    public int fuerza = 20;
    public float salto = 8f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent < SpriteRenderer>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        Vector2 movimiento = new Vector2(movimientoHorizontal, 0);

        rb.velocity = new Vector2(movimiento.x * velocidad, rb.velocity.y);

        // Girar el sprite en función de la dirección
        if (movimientoHorizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movimientoHorizontal > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Salto
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo") || collision.gameObject.CompareTag("zombie"))
        {
            isJumping = false;
        }
    }
}
