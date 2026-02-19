using UnityEngine;

public class DeteccionCercaniaBoton : MonoBehaviour
{
    public TextMesh texto;

    void Update()
    {
        texto.text = " ";

        if (OVRInput.Get(OVRInput.NearTouch.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            texto.text = "El dedo esta cerca del trigger derecho";
        }

        if (OVRInput.Get(OVRInput.Touch.One, OVRInput.Controller.RTouch))
        {
            texto.text = "El dedo esta tocando el boton A del mando"; 
        }
    }
}
