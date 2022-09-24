using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ButtonManager : MonoBehaviour
{
    public bool isSpoonActive;
    public bool isKniveActive;

    // cursor texture shit
    public Texture2D knifeCursor;
    public Texture2D spoonCursor;
    public CursorMode cursorMode = CursorMode.Auto; // auto = scales texture to system, forcedhardware = forces to texture size
    public Vector2 hotSpot = Vector2.zero;          // hotspot is where on the texture the clicky-bit is

    // Start is called before the first frame update
    void Start()
    {
        this.isKniveActive = false;
        this.isSpoonActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpoonActiveInactive()
    {
        if (!this.isSpoonActive && !this.isKniveActive)
        {
            this.isSpoonActive = true;
            Debug.Log("Spoon Active!");
            ChangeCursorToSpoon();
        }
        else if (!this.isSpoonActive && this.isKniveActive)
        {
            this.isKniveActive = false;
            this.isSpoonActive = true;
            Debug.Log("Spoon Active, Knife inactive!");
            ChangeCursorToSpoon();
        }
        else if (this.isSpoonActive && !this.isKniveActive)
        {
            this.isSpoonActive = false;
            Debug.Log("Spoon Inactive!");
            ChangeCursorToDefault();
        }
    }

    public void KnifeActiveInactive()
    {
        if (!this.isKniveActive && !this.isSpoonActive)
        {
            this.isKniveActive = true;
            Debug.Log("Knife Active!");
            ChangeCursorToKnife();
        }
        else if(!this.isKniveActive && this.isSpoonActive)
        {
            this.isSpoonActive = false;
            this.isKniveActive = true;
            Debug.Log("Knife active and spoon inactive!");
            ChangeCursorToKnife();
        }
        else if (this.isKniveActive)
        {
            this.isKniveActive = false;
            Debug.Log("Knife Inactive!");
            ChangeCursorToDefault();
        }
    }


    public void ChangeCursorToKnife()
    {
        this.cursorMode = CursorMode.ForceSoftware;
        this.hotSpot = new Vector2(0f, 0f);
        Cursor.SetCursor(this.knifeCursor, this.hotSpot, this.cursorMode);
        
    }

    public void ChangeCursorToSpoon()
    {
        this.cursorMode = CursorMode.ForceSoftware;
        this.hotSpot = new Vector2(0f, 0f);
        Cursor.SetCursor(this.spoonCursor, this.hotSpot, this.cursorMode);
    }

    public void ChangeCursorToDefault()
    {
        this.cursorMode = CursorMode.Auto;
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
