using UnityEngine;

public class BallestaController : MonoBehaviour
{
    public GameObject flecha;
    public GameObject ballesta;
    public Transform firePoint;
    public float vFlecha = 10.0f;
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            DispararFlecha();
        }
    }

    public void DispararFlecha() 
    {
        GameObject newFlecha = Instantiate(flecha, firePoint.position, firePoint.rotation);
        newFlecha.GetComponent<Rigidbody>().linearVelocity = firePoint.forward * vFlecha;
    }
}
