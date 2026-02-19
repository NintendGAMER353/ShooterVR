using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public AudioClip PlayButtonSound;
    public AudioClip ExitButtonSound;
    private AudioSource audioMenu;

    void Awake()
    {
        audioMenu = GetComponent<AudioSource>();
    }

    public void PlayPlayButtonSound()
    {
        StartCoroutine(WaitSoundPlay());
    }

    public void PlayExitButtonSound()
    {
        StartCoroutine(WaitSoundExit());
    }

    IEnumerator WaitSoundPlay()
    {
        audioMenu.PlayOneShot(PlayButtonSound);
        yield return new WaitForSeconds(1f);
    }

    IEnumerator WaitSoundExit()
    {
        audioMenu.PlayOneShot(ExitButtonSound);
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}