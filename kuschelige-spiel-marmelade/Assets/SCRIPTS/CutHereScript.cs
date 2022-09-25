using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutHereScript : MonoBehaviour
{
    public GameObject buttonManager;
    BoxCollider2D boxCollider;
    public GameObject pumpkinHat;
    Rigidbody2D pumpkinHatRigidBody;
    // this.isKniveActive = this.buttonManager.GetComponent<BottonManager>().isKniveActive;     <-- need to call this every time we want the value
    public GameObject sceneManager;
    public GameObject noiseManager;
    Vector3 pumpkinHatPosition;

    // Start is called before the first frame update
    void Start()
    {
        this.boxCollider = GetComponent<BoxCollider2D>();
        this.pumpkinHatRigidBody = this.pumpkinHat.GetComponent<Rigidbody2D>();
        this.pumpkinHatPosition = this.pumpkinHat.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDrag()
    {
        if (this.buttonManager.GetComponent<ButtonManager>().isKniveActive)
        {
            // move hat of pumpkin up a bit
            Vector3 totalMovement = new Vector3(0.0f, 0.1f, 0.0f);
            this.pumpkinHat.transform.position = this.pumpkinHatPosition + totalMovement;
            // set to phase 1
            this.sceneManager.GetComponent<ScrapingoutPimpkinScript>().ChangeToPhase(1);
        }
    }


    void OnMouseDown()
    {
        if (this.buttonManager.GetComponent<ButtonManager>().isKniveActive)
        {
            // play carving nosie
            this.noiseManager.GetComponent<NoiseManager>().PlayCarvingNoise();

        }
    }

}
