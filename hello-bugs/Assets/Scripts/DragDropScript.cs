﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropScript : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Debug.Log("Wciśnięto");
        this.transform.position = Input.mousePosition;
        this.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}