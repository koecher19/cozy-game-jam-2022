using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePumpkinHatAround : MonoBehaviour
{
    public GameObject buttonManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        if(!this.buttonManager.GetComponent<ButtonManager>().isSpoonActive && !this.buttonManager.GetComponent<ButtonManager>().isKniveActive) // player can only drag hat around if their hands are free
        {
            Debug.Log("yes");
            Vector3 mousePos = Input.mousePosition;
            Debug.Log(mousePos);
            this.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }
}
