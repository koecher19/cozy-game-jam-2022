using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReduceHitboxToSprite : MonoBehaviour
{
    private Image targetGraphic;
    // Start is called before the first frame update
    void Start()
    {
        targetGraphic = this.GetComponent<Image>();
        targetGraphic.alphaHitTestMinimumThreshold = 0.5f;

    }
}
