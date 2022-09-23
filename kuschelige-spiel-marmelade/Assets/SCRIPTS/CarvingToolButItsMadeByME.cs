using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarvingToolButItsMadeByME : MonoBehaviour
{
    public bool toolIsActive;

    // cursor shit
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        this.toolIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetToolStatus(bool active)
    {
        this.toolIsActive = active;
        if (this.toolIsActive)
        {
            this.hotSpot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
        else if (!this.toolIsActive)
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
    }
}
