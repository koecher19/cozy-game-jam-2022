using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ButtonManager : MonoBehaviour
{
    public bool isSpoonActive;
    public bool isFullSpoonActive;
    public bool isKniveActive;

    // cursor texture shit
    public Texture2D knifeCursor;
    public Texture2D spoonCursor;
    public Texture2D fullSpoonCursor;
    public CursorMode cursorMode = CursorMode.Auto; // auto = scales texture to system, forcedhardware = forces to texture size
    public Vector2 hotSpot = Vector2.zero;          // hotspot is where on the texture the clicky-bit is

    public GameObject pumpkinBootySprites;
    public GameObject bowlSprite;
    public GameObject noiseManager;

    // Start is called before the first frame update
    void Start()
    {
        this.isKniveActive = false;
        this.isSpoonActive = false;
        this.isFullSpoonActive = false;
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
            ChangeCursorToSpoon();
        }
        else if (!this.isSpoonActive && this.isKniveActive)
        {
            this.isKniveActive = false;
            this.isSpoonActive = true;
            ChangeCursorToSpoon();
        }
        else if (this.isSpoonActive && !this.isKniveActive)
        {
            this.isSpoonActive = false;
            ChangeCursorToDefault();
        }
    }

    public void KnifeActiveInactive()
    {
        if (!this.isKniveActive && !this.isSpoonActive)
        {
            this.isKniveActive = true;
            ChangeCursorToKnife();
        }
        else if(!this.isKniveActive && this.isSpoonActive)
        {
            this.isSpoonActive = false;
            this.isKniveActive = true;
            ChangeCursorToKnife();
        }
        else if (this.isKniveActive)
        {
            this.isKniveActive = false;
            ChangeCursorToDefault();
        }
    }

    public void FillSpoon()
    {
        if (this.isSpoonActive)
        {
            this.isSpoonActive = false;
            this.isFullSpoonActive = true;
            this.noiseManager.GetComponent<NoiseManager>().PlayScoopingNoise();
            ChangeCursorToFullSpoon();
        }
    }

    public void EmptySpoon()
    {
        if (this.isFullSpoonActive)
        {
            this.isFullSpoonActive = false;
            this.isSpoonActive = true;
            this.noiseManager.GetComponent<NoiseManager>().PlayBowlNoise();
            ChangeCursorToSpoon();
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

    public void ChangeCursorToFullSpoon()
    {
        this.cursorMode = CursorMode.ForceSoftware;
        this.hotSpot = new Vector2(0f, 0f);
        Cursor.SetCursor(this.fullSpoonCursor, this.hotSpot, this.cursorMode);
    }

    public void ChangeCursorToDefault()
    {
        this.cursorMode = CursorMode.Auto;
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    public void ScoopOutPumpkinBooty()
    {
        // test if spoon is empty and if pumpkin isnt empty
        if (this.isSpoonActive && this.pumpkinBootySprites.GetComponent<FlipThroughPumpkinsWhileScooping>().currentState < this.pumpkinBootySprites.GetComponent<FlipThroughPumpkinsWhileScooping>().countOfStates-1)
        {
            this.pumpkinBootySprites.GetComponent<FlipThroughPumpkinsWhileScooping>().NextState();
            this.FillSpoon();
        }
    }

    public void ScoopIntoBowl()
    {
        // test if spoon is full
        if (this.isFullSpoonActive)
        {
            this.EmptySpoon();
            this.bowlSprite.GetComponent<FillThatShitUp_theBowlIfAnyoneIsAsking>().YeahFillItUp();

        }
    }
}
