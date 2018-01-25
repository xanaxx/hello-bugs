using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public AudioSource AudioSource;
    public AudioClip ButtonClip;
    private float waitTime;

    public void PlayGame()
    {
        StartCoroutine(PlayButtonHit("Game"));
    }

    public void QuitGame()
    {
        StartCoroutine(PlayButtonHit("quit"));
    }

    public void QuitMenu()
    {
        StartCoroutine(PlayButtonHit("Menu"));
    }

    IEnumerator PlayButtonHit(string scene)
    {
        AudioSource.Stop();
        AudioSource.PlayOneShot(ButtonClip);
        yield return new WaitForSecondsRealtime(ButtonClip.length - 1.5f);
        if (scene != "quit")
        {
            SceneManager.LoadScene(scene);
            yield break;
        }
        Application.Quit();
        Debug.Log("EXIT");
    }
}
