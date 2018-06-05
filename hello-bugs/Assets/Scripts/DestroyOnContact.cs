using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip audioClp;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        audioSrc.PlayOneShot(audioClp);
    }
}
