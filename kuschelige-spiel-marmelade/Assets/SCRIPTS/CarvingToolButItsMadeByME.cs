using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CarvingToolButItsMadeByME : MonoBehaviour
{
    public bool toolIsActive;
    public GameObject pumpkinForeground;
    public Texture2D pumpkinForegroundTexture;
    public BoxCollider2D pumpkinCollider;

    Color clearColor;

    // cursor shit
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        this.toolIsActive = false;
        this.pumpkinForegroundTexture = this.pumpkinForeground.GetComponent<RawImage>().texture as Texture2D;
        this.pumpkinCollider = this.pumpkinForeground.GetComponent<BoxCollider2D>();

        this.clearColor = new Vector4(0f, 0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetToolStatus(bool active)
    {
        this.toolIsActive = active; // sets tool as active or inactive according to bool

        if (this.toolIsActive)
        {
            this.cursorMode = CursorMode.ForceSoftware;
            // this.hotSpot = new Vector2(cursorTexture.width / 2f, cursorTexture.height / 2);
            this.hotSpot = new Vector2(0f, 0f);
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
        else if (!this.toolIsActive)
        {
            this.cursorMode = CursorMode.Auto;
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
    }

    public void Carve()
    {
        Debug.Log("we're carving!");

        if (this.toolIsActive)
        {
            Vector3 mousePos = Input.mousePosition;
            int cutxValue = Convert.ToInt32(mousePos.x/2);
            int cutyValue = Convert.ToInt32(mousePos.y/2);

            int cutRadius = 2;

            for (int x = cutxValue - cutRadius; x < cutxValue + cutRadius; x++)
            {
                for (int y = cutyValue - cutRadius; y < cutyValue + cutRadius; y++)
                {
                    this.pumpkinForegroundTexture.SetPixel(x, y, this.clearColor);
                }
            }

            //this.pumpkinForegroundTexture.SetPixel(Convert.ToInt32(mousePos.x), Convert.ToInt32(mousePos.y), this.clearColor);

            this.pumpkinForegroundTexture.Apply();
        }

    }

}
