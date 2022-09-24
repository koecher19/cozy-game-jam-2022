using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFix : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 scaleVector;
    void Start()
    {
        scaleVector.Set(1.6f, 1.6f, 1);
        this.transform.localScale = scaleVector;
    }

}
