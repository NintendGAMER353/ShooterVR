using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public TextMeshPro text;
    public static int puntuacion = 0;

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Tu puntuacion es de: " + puntuacion);
        if (collision.gameObject.CompareTag("Diana"))
        {
            puntuacion++;
            text.SetText("Puntuacion: " + puntuacion);
            Destroy(gameObject);
        }
    }
}
