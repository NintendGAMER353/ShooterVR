using UnityEngine;

public class DianaController : MonoBehaviour
{
    [Header("Posiciones")]
    public Vector3 InitialPos; // Posición inicial de la diana
    public Vector3 FinalPos;   // Posición final a la que se mueve

    [Header("Movimiento")]
    public float speed = 1.5f;   // Velocidad de movimiento
    public float waitTime = 5f;  // Tiempo que espera al llegar a la posición final

    [Header("Control")]
    public bool movimientoInfinito = true; // Si true, la diana sigue moviéndose en ciclo

    [Header("Colores")]
    public Color colorImpacto = Color.red; // Color que toma la diana al recibir un impacto

    public GameManager gameManager; // Referencia al GameManager para sumar puntos

    private bool movingUp = true;      // Si la diana está subiendo
    private bool waiting = false;      // Si está en pausa en la posición final
    private float timer = 0f;          // Temporizador para la pausa

    private bool puedeRecibirImpacto = true; // Solo permite un impacto por ciclo

    private Renderer rend;      // Renderer para cambiar el color
    private Color colorOriginal; // Color inicial de la diana

    private void Start()
    {
        // Inicializamos la posición de la diana
        transform.position = InitialPos;

        // Buscamos el Renderer, puede estar en un hijo
        rend = GetComponentInChildren<Renderer>();

        if (rend != null)
        {
            // Creamos una copia del material para no afectar a otros objetos que usen el mismo
            rend.material = new Material(rend.material);
            colorOriginal = rend.material.color; // Guardamos el color original
        }
        else
        {
            Debug.LogError("No se encontró ningún Renderer en la Diana.");
        }
    }

    private void Update()
    {
        if (!movimientoInfinito) return; // Si no es infinito, no hacemos nada

        if (movingUp)
        {
            // Movemos la diana hacia la posición final
            transform.position = Vector3.MoveTowards(transform.position, FinalPos, speed * Time.deltaTime);

            // Si llegamos casi a la posición final
            if (Vector3.Distance(transform.position, FinalPos) < 0.01f)
            {
                transform.position = FinalPos; // Ajuste preciso
                movingUp = false;               // Cambiamos dirección
                waiting = true;                 // Activamos la pausa
                timer = 0f;                     // Reiniciamos temporizador
            }
        }
        else if (waiting)
        {
            // Contamos el tiempo de espera
            timer += Time.deltaTime;

            if (timer >= waitTime)
                waiting = false; // Terminó la pausa, comenzará a bajar
        }
        else
        {
            // Movemos la diana de vuelta a la posición inicial
            transform.position = Vector3.MoveTowards(transform.position, InitialPos, speed * Time.deltaTime);

            // Si llegó a la posición inicial
            if (Vector3.Distance(transform.position, InitialPos) < 0.01f)
            {
                transform.position = InitialPos;

                // Reiniciamos el ciclo
                movingUp = true;
                puedeRecibirImpacto = true; // Permitimos recibir otro impacto

                // Restauramos el color original
                if (rend != null)
                    rend.material.color = colorOriginal;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificamos si el objeto que chocó es una flecha
        Flecha flecha = collision.gameObject.GetComponent<Flecha>();

        if (flecha != null && puedeRecibirImpacto)
        {
            RecibirImpacto(); // Cambiar color y sumar puntos

            // Destruimos la flecha tras el impacto
            Destroy(collision.gameObject);
        }
    }

    public void RecibirImpacto()
    {
        if (!puedeRecibirImpacto) return; // Ya recibió un impacto este ciclo

        puedeRecibirImpacto = false;

        Debug.Log("Diana impactada!");

        // Cambiamos el color de la diana al color de impacto
        if (rend != null)
            rend.material.color = colorImpacto;

        // Llamamos al GameManager para sumar 1 punto
        if (gameManager != null)
            gameManager.SumarPunto();
    }
}