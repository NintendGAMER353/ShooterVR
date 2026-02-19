using UnityEngine;

public class ThumbSticks : MonoBehaviour
{
    //Variables
    public GameObject objectToMove; //Objeto a mover
    public float moveSpeed = 2; //Velocidad a la que lo movemos

    void Update()
    {   //Capturamos el input del thumbstick del mando derecho
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        //Aplicar el movimiento a un objeto
        Vector3 moveDirection = new Vector3(thumbstickInput.x, 0, thumbstickInput.y);

        objectToMove.transform.Translate(moveDirection *moveSpeed * Time.deltaTime, Space.World);
    }
}
