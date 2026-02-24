using UnityEngine;
using System.Collections;

public class BallestaController : MonoBehaviour
{
    public GameObject flecha;
    public Transform firePoint;
    public float vFlecha = 25f;
    public float tiempoVidaFlecha = 10f;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            DispararFlecha();
        }
    }

    void DispararFlecha()
    {
        GameObject newFlecha = Instantiate(flecha, firePoint.position, firePoint.rotation);

        Rigidbody rb = newFlecha.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * vFlecha;

        Destroy(newFlecha, tiempoVidaFlecha);

        OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.RTouch);
        StartCoroutine(StopVibration(0.1f));
    }

    IEnumerator StopVibration(float duration)
    {
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
    }
}