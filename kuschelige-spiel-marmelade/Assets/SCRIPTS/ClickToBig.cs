using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToBig : MonoBehaviour
{
    private Vector3 bigScale, smallScale;
    private bool isBig;

    void Start()
    {
        bigScale = new Vector3(2f, 2f, 2f);
        smallScale = new Vector3(1.5f, 1.5f, 1.5f);
        isBig = true;
    }

    private void OnMouseDown()
    {
        transform.localScale = isBig ? smallScale : bigScale;
        isBig = !isBig;
    }
}
