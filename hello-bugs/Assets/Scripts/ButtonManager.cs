using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using  UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonManager : MonoBehaviour
{

    public AudioClip sound;
    public string scene;
    public AudioSource BgSource;

    private Button button
    {
        get
        {
            return GetComponent<Button>();
        }
    }

    private AudioSource source
    {
        get
        {
            return GetComponent<AudioSource>();
        }
    }

    public void Start()
    {
        Time.timeScale = 1.0F;
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => StartCoroutine("WaitAudioLength"));

    }

    IEnumerator WaitAudioLength()
    {
        BgSource.Stop();
        source.PlayOneShot(sound);
        yield return new WaitForSecondsRealtime(sound.length);
        if (scene != "quit")
        {
            SceneManager.LoadScene(scene);
            yield break;
        }
        Application.Quit();
        Debug.Log("EXIT");
    }


}
