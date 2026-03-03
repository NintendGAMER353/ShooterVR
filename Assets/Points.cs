using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // Para reiniciar o acabar la partida

public class GameManager : MonoBehaviour
{
    public TextMeshPro puntuacionText;

    private int puntuacion = 0;

    // Llamado desde DianaController al impactar
    public void SumarPunto()
    {
        puntuacion++;
        puntuacionText.SetText("" + puntuacion);

        Debug.Log("Puntuación actual: " + puntuacion);
    }
}