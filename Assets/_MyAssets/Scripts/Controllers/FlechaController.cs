using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Flecha : MonoBehaviour
{
    private Rigidbody rb;
    public static int puntuacion = 0;
    public TextMeshPro text;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.linearVelocity.sqrMagnitude > 0.01f)
        {
            transform.forward = rb.linearVelocity.normalized;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("Tu puntuacion es de: " +puntuacion);
        if (collision.gameObject.CompareTag("Diana"))
        {
            puntuacion++;
            text.SetText("Puntuacion: " + puntuacion);
            Destroy(gameObject);
        }
    }
}