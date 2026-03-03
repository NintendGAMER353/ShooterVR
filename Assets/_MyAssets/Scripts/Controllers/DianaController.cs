using UnityEngine;

public class DianaController : MonoBehaviour
{
    public Vector3 InitialPos;
    public Vector3 FinalPos;
    public float speed = 1.5f;

    private bool movingUp = true;
    private float timer = 0f;
    private bool waiting = false;


    private void Update()
    {
        if (movingUp)
        {
            // Muevo la diana hacia arriba poco a poco
            transform.position = Vector3.MoveTowards(transform.position, FinalPos, speed * Time.deltaTime);

            // Cuando llega arriba del todo, espero 5 segundos antes de bajarla
            if (Vector3.Distance(transform.position, FinalPos) < 0.01f)
            {
                transform.position = FinalPos;
                movingUp = false;
                waiting = true;
                timer = 0f;
            }
        }
        else if (waiting)
        {
            // Cuento los 5 segundos
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                // Ya pasaron los 5 segundos, que empiece a bajar
                waiting = false;
            }
        }
        else
        {
            // Bajo la diana de vuelta a su posición original
            transform.position = Vector3.MoveTowards(transform.position, InitialPos, speed * Time.deltaTime);
        }
    }
}