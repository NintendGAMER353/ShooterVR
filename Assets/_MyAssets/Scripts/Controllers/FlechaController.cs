using UnityEngine;

public class Flecha : MonoBehaviour
{
    private Rigidbody rb;

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
        Destroy(gameObject);
    }
}