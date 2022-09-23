using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggiDroppi : MonoBehaviour
{
    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;

    private void OnMouseDown()
    {
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseDrag()
    {
        if (isDragged)
        {
            transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToViewportPoint(Input.mousePosition) - mouseDragStartPosition);
        }
    }

    private void OnMouseUp() 
    {
        isDragged = false;
    }
}