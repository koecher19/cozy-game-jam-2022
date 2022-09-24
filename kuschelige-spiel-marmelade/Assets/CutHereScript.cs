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
            Debug.Log("WERE CUTTING!!");
            // TODO: idk make the top of the pumpkin move a litte?
            Vector3 totalMovement = new Vector3(0.0f, 0.1f, 0.0f);
            this.pumpkinHat.transform.position = this.pumpkinHatPosition + totalMovement;
            // TODO: set to phase 1
            this.sceneManager.GetComponent<ScrapingoutPimpkinScript>().ChangeToPhase(1);
        }
    }
    
}
