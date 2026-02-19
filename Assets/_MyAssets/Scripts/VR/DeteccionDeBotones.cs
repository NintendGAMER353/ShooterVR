using UnityEngine;

public class DeteccionDeBotones : MonoBehaviour
{
    public TextMesh texto; //Aqui enlazaremos el texto 3D de la escena

    // Update is called once per frame
    void Update()
    {
        texto.text = " "; //Borramos constantemente el texto

        //Dectectar el boton A en el controlador derecho
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            texto.text = "Boton A derecho presionado"; 
        }

        //Detectar el boton B en el controlador derecho
        if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            texto.text = "Boton B derecho presionado";
        }

        //Detectar el boton X en el controlador izquierdo
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            texto.text = "Boton X izquierdo presionado";
        }

        //Detectar el boton en el controlador
        if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            texto.text = "Boton Y izquierdo presionado";
        }

        //Detectar la pulsacion del gatillo del controlador derecho
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            texto.text = "Gatillo derecho pulsado";
        }

        //Detectar la pulsacion del gatillo del controlador izquierdo
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            texto.text = "Gatillo izquierdo pulsado";
        }

        //Detectar pulsacion del Grip en el controlador derecho
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            texto.text = "Grip derecho pulsado";
        }

        //Detectar pulsacion del Grip en el controlador izquierdo
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            texto.text = "Grip derecho pulsado";
        }

        //Detectar pulsacion del thumbstick izquierdo
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            texto.text = "Grip derecho pulsado";
        }

        //Detectar pulsacion del thumbstick izquierdo
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            texto.text = "Boton thumbstick izquierdo pulsado";
        }

        //Detectar pulsacion del thumbstick derecho
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            texto.text = "Boton thumbstick derecho pulsado";
        }
    }
}
