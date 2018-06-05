using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointController : MonoBehaviour
{
    public Button StartButton;
    public string SceneName;
    private static int score;

    public static int Score
    {
        get { return score; }
        set { score = value; }
    }


    private static Int32 scoResult;

    public void Start()
    {
        //StartButton.onClick.AddListener(() => { SceneManager.LoadScene(SceneName); });
    }


    public static void AddPoint(int value)
    {
        score = score + value;
    }

}
