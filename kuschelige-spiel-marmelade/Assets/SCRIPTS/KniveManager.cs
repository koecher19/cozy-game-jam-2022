using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KniveManager : MonoBehaviour
{
    public bool isKnivePickedUp = false;
    public GameObject kniveButton;
    public GameObject carvingManager;

    // Start is called before the first frame update
    void Start()
    {
        this.kniveButton = this.gameObject.transform.Find("knive button").gameObject;
        this.isKnivePickedUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickupPutdownKnive()
    {
        if (!this.isKnivePickedUp)
        {
            this.isKnivePickedUp = true;
            // disable image in button
            //this.kniveButton.GetComponent<Image>().enabled = false;
            // set carving as active
            this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().SetToolStatus(true);
            // clip image of knive to cursor
            // start mode to CUT the pumpkin! FUCK IT UP!
        }

        else if (this.isKnivePickedUp)
        {
            this.isKnivePickedUp = false;
            // enable image in button
            //this.kniveButton.GetComponent<Image>().enabled = true;
            // set carving as inactive
            this.carvingManager.GetComponent<CarvingToolButItsMadeByME>().SetToolStatus(false);
        }
    }
}
