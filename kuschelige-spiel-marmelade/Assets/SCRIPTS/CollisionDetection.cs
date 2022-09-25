using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject carvingManager;
    public GameObject noiseManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Debug.Log("clicked on pumpkin hehe");
        this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().Carve();
        if (this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().toolIsActive)
        {
            this.noiseManager.GetComponent<NoiseManager>().PlayCarvingNoise();
        }
    }
    void OnMouseDrag()
    {
        this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().Carve();
    }
}
