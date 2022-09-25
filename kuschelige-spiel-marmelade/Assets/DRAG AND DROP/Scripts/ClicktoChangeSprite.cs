using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicktoChangeSprite : MonoBehaviour
{
    [SerializeField]
    private Sprite smallSprite, bigSprite;
    private bool isBig;
    private SpriteRenderer rend;
    private BoxCollider2D newCollider;

    void Start()
    {
        newCollider = gameObject.AddComponent<BoxCollider2D>();
        isBig = false;
        rend = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        rend.sprite = isBig ? smallSprite : bigSprite;
        isBig = !isBig;
        Destroy(newCollider);
        newCollider = gameObject.AddComponent<BoxCollider2D>();
        newCollider.isTrigger = true;
    }
}
