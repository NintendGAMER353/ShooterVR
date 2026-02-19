using UnityEngine;

public class ObtenerPosControladores : MonoBehaviour
{

    void Update()
    {
        //Obtenemos la posicion del controlador izquierdo
        Vector3 leftControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);

        //Obtenemos la posicion del controlador derecho
        Vector3 RightControllerPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);

        //Obtener la rotacion del controlador izquierdo
        Vector3 leftControllerRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch).eulerAngles;

        //Obtener la rotacion del controlador derecho
        Vector3 RightControllerRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch).eulerAngles;

        Debug.Log("L pos - " + leftControllerPosition + " L rot - " +leftControllerRotation + " R pos - " + RightControllerPosition + " R rot - " + RightControllerRotation);

    }
}
