using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    public Camera cam;


    private Rigidbody2D rigidbody2;
    private Renderer rnderer;
    private float maxWidth;

    // Use this for initialization
    void Start() 
    {
        if (cam == null)
            cam = Camera.main;

        rigidbody2 = GetComponent<Rigidbody2D>();

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 screenWidth = cam.ScreenToWorldPoint(upperCorner);

        rnderer = GetComponent<Renderer>(); 

        float playerWidth = rnderer.bounds.extents.x;
        maxWidth = screenWidth.x - playerWidth;
    }

    // Update is called once per physics timestep
    void FixedUpdate()
    {
        Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3(rawPosition.x, 0.0f, 0.0f);
        float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth, maxWidth);
        targetPosition = new Vector3(targetWidth, targetPosition.y, targetPosition.y);
        rigidbody2.MovePosition(targetPosition);
    }
}
 