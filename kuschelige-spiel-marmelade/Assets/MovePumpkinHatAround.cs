using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePumpkinHatAround : MonoBehaviour
{
    public GameObject buttonManager;
    public GameObject sceneManager;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        this.cam = Camera.main;
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
            //this.transform.position = new Vector3(mousePos.x - 250, mousePos.y - 400, 0);
            this.transform.position = cam.ScreenToWorldPoint(mousePos);
            Debug.Log(cam.ScreenToWorldPoint(mousePos));
        }
    }

    void OnMouseUp()
    {
        if (!this.buttonManager.GetComponent<ButtonManager>().isSpoonActive && !this.buttonManager.GetComponent<ButtonManager>().isKniveActive)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

            // now up to phase 2!!
            this.sceneManager.GetComponent<ScrapingoutPimpkinScript>().ChangeToPhase(2);
        }
    }
}
