using UnityEngine;

public class ObtenerPosGafas : MonoBehaviour
{
    //Variables
    public Transform centerEyeAnchor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Obtener la posicion del casco (gafas)
        Vector3 headsetPosition = centerEyeAnchor.position;

        //Capturamos la rotacion del casco y lo pasamos a euler
        Vector3 headsetRotation = centerEyeAnchor.rotation.eulerAngles;

        Debug.Log("Gafas pos - " + headsetPosition + " Gafas rot - " + headsetRotation);
    }
}
