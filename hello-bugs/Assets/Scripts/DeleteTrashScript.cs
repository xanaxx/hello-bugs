using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
using UnityEngineInternal.Input;

public class DeleteTrashScript : MonoBehaviour
{
    public string requiredTag;
    public Text TextField;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == requiredTag)
        {
            Destroy(other.gameObject);
            PointController.AddPoint(2);
            TextField.text = PointController.Score.ToString();
        }
    }
}
