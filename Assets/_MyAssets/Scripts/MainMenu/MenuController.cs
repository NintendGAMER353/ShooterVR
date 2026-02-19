using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public SoundManager sm;

    public void StartAction()
    {
        Debug.Log("Start");
        sm.PlayPlayButtonSound();
        SceneManager.LoadScene("GameScene");
    }

    public void ExitAction()
    {
        Debug.Log("Exit Game");
        sm.PlayExitButtonSound();
        Application.Quit();
    }

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.C))
    //    {
    //        Debug.Log("Entra Exit Menú");
    //        sm.PlayCreditsButtonSound();
    //        SceneManager.LoadScene("MainMenu");
    //    }

    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        Debug.Log("Entra Exit Juego");
    //        sm.PlayCreditsButtonSound();
    //        Application.Quit();
    //    }
    //}
}

