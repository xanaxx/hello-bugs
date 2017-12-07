using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal.Input;

public class DeleteTrashScript : MonoBehaviour
{
    public string requiredTag;
    public PointControllerScript pointController;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == requiredTag)
            Destroy(other.gameObject);

    }
}
