using UnityEngine;

public class Jugador : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 5f;

    [Header("Salto")]
    public float alturaSalto = 4f;

    [Header("Comprobación del piso")]
    public Transform comprobadorPiso;
    public float radio = 0.1f;
    public LayerMask layerPiso;

    private Rigidbody2D rb;
    private float movimiento;
    private bool esPiso;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimiento horizontal
        movimiento = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(
            movimiento * velocidad,
            rb.linearVelocity.y
        );

        // Girar personaje
        if (movimiento != 0)
        {
            transform.localScale = new Vector3(
                Mathf.Sign(movimiento),
                1,
                1
            );
        }

        // Salto
        if (Input.GetButtonDown("Jump") && esPiso)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                alturaSalto
            );
        }
    }

    void FixedUpdate()
    {
        // Comprobar si está sobre el piso
        if (comprobadorPiso != null)
        {
            esPiso = Physics2D.OverlapCircle(
                comprobadorPiso.position,
                radio,
                layerPiso
            );
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (comprobadorPiso != null)
        {
            Gizmos.DrawWireSphere(
                comprobadorPiso.position,
                radio
            );
        }
    }
}