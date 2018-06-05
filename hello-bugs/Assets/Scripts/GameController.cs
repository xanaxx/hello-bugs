using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject trash;
    public float timeLeft;
    public TextMeshProUGUI timerText;
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public AudioSource audioSrc;
    public AudioSource audioSrc2;
    public AudioClip audioClp;

    public bool isDead = false;
    private bool read = false;

    private Camera cam;
    private Renderer rnderer;
    private float maxWidth;

    // Use this for initialization
    void Start()
    {
        if (cam == null)
            cam = Camera.main;

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 screenWidth = cam.ScreenToWorldPoint(upperCorner);
        rnderer = trash.GetComponent<Renderer>();
        float trashWidth = rnderer.bounds.extents.x;
        maxWidth = screenWidth.x - trashWidth;
        UpdateText();
    }

    public void MakeDead(bool stat)
    {
        isDead = stat;
    }

    public void Readme()
    {
        read = true;
        panel2.SetActive(false);
        panel3.SetActive(true);
        StartCoroutine(Spawn());
    }

    private bool checkme = true;

    private void FixedUpdate()
    {
        if (read)
        {

            if (!isDead)
            {
                timeLeft -= Time.deltaTime;
                UpdateText();
            }
            else
            {
                if (checkme)
                {
                    panel.SetActive(true);
                    audioSrc.PlayOneShot(audioClp);
                    audioSrc2.Stop();
                    checkme = false;
                }
            }
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.0f);
        while (!isDead && read)
        {
                Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(trash, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }
    }

    void UpdateText()
    {
        timerText.text = "Time Left:\n" + Mathf.RoundToInt(timeLeft).ToString();
    }

}
