using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillThatShitUp_theBowlIfAnyoneIsAsking : MonoBehaviour
{
    public int currentState;
    public int maxState = 3; // we have 3 states but we start counting at zero bc computers
    // Start is called before the first frame update
    public GameObject SceneManager;
    public Sprite fullBowl;

    void Start()
    {
        this.currentState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YeahFillItUp()
    {
        if(this.currentState < maxState)
        {
            this.currentState++;
            if (this.currentState == this.maxState)
            {
                GetComponent<SpriteRenderer>().sprite = this.fullBowl;
                this.SceneManager.GetComponent<ScrapingoutPimpkinScript>().ChangeToPhase(3);
            }
        }
    }
}
