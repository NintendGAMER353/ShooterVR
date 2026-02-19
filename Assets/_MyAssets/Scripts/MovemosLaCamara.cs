using Oculus.Interaction.Editor;
using UnityEngine;

public class MovemosLaCamara : MonoBehaviour
{
    //Variables
    public float moveSpeed = 2; //Velocidad de movimiento


    void Update()
    {
        //Capturamos el input de ambos thumbsticks
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick); //Mando derecho
        Vector2 thumbstick2Input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick); //Mando izquierdo

        //Aplicamo el movimiento al objeto
        Vector3 moveDirection = new Vector3(thumbstickInput.x, thumbstick2Input.y, thumbstickInput.y);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
