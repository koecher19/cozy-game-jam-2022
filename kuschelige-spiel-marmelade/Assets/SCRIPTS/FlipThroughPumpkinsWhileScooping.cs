using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipThroughPumpkinsWhileScooping : MonoBehaviour
{
    public Sprite[] pumpkinStates;
    public int countOfStates;
    public int currentState;
    // Start is called before the first frame update
    void Start()
    {
        this.countOfStates = this.pumpkinStates.Length;
        this.currentState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextState()
    {
        if (this.currentState < this.countOfStates - 1)
        {
            GetComponent<SpriteRenderer>().sprite = this.pumpkinStates[this.currentState + 1];
            this.currentState++;
            Debug.Log("called pumpkin booty nextstate");
        }
    }
}
