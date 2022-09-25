using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePumpkinHatAround : MonoBehaviour
{
    public GameObject buttonManager;
    public GameObject sceneManager;

    public bool putHatBackOnPumpkin;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        this.cam = Camera.main;
        this.putHatBackOnPumpkin = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        if(!this.buttonManager.GetComponent<ButtonManager>().isSpoonActive && !this.buttonManager.GetComponent<ButtonManager>().isKniveActive) // player can only drag hat around if their hands are free
        {
            //Debug.Log("yes");
            Vector3 mousePos = Input.mousePosition;
            //Debug.Log(mousePos);
            //this.transform.position = new Vector3(mousePos.x - 250, mousePos.y - 400, 0);
            this.transform.position = cam.ScreenToWorldPoint(mousePos);
            //Debug.Log(cam.ScreenToWorldPoint(mousePos));
        }
        if (this.putHatBackOnPumpkin)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
    }

    void OnMouseUp()
    {
        if (!this.buttonManager.GetComponent<ButtonManager>().isSpoonActive && !this.buttonManager.GetComponent<ButtonManager>().isKniveActive && !this.putHatBackOnPumpkin)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

            // now up to phase 2!!
            this.sceneManager.GetComponent<ScrapingoutPimpkinScript>().ChangeToPhase(2);
        }
        else if(!this.buttonManager.GetComponent<ButtonManager>().isSpoonActive && !this.buttonManager.GetComponent<ButtonManager>().isKniveActive && this.putHatBackOnPumpkin)
        {
            if (this.transform.position.x < 0.5f && this.transform.position.x > -0.5f 
                && this.transform.position.y < 4.0f && this.transform.position.y > 2.0f)
            {
                GetComponent<Rigidbody2D>().gravityScale = 0;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                this.transform.position = new Vector3(0.0f, 3.807f, 0.0f);
                // TODO enter next phase
                this.sceneManager.GetComponent<ScrapingoutPimpkinScript>().ChangeToPhase(4);
            }
        }
    }
}
