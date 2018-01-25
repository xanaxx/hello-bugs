using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer spriteRndrer = GetComponent<SpriteRenderer>();
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites\\recycle_items");
        spriteRndrer.sprite = sprites[Random.Range(0, 15)];
    }

}
