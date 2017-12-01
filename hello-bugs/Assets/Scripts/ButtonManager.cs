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
        source.PlayOneShot(sound);
        yield return new WaitForSecondsRealtime(sound.length);
        SceneManager.LoadScene(scene);
    }


}
