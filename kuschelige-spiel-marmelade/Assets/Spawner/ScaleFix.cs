using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFix : MonoBehaviour
{
    public float newScale = 1.6f;
    // Start is called before the first frame update
    private Vector3 scaleVector;
    void Start()
    {
        scaleVector.Set(newScale, newScale, 1);
        this.transform.localScale = scaleVector;
    }

}
