using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject carvingManager;

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
        Debug.Log("clicked on pumpkin hehe");
        this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().Carve();
    }
    void OnMouseDrag()
    {
        this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().Carve();
    }
}
