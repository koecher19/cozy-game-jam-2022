using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapingoutPimpkinScript : MonoBehaviour
{
    [SerializeField] // (makes private variables, methods visible in the inspector)
    int phase;
    /*
    phase 0: cut off the top
    phase 1: remove the top from pumpkin
    phase 2: remove innards from pumpkin
    phase 3: put pumpkin head back on
     */

    public GameObject pumpkinLid;
    public GameObject cutHere;

    // Start is called before the first frame update
    void Start()
    {
        ChangeToPhase(0);

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeToPhase(int phaseToChangeTo)
    {
        switch (phaseToChangeTo)
        {
            case 0:
                this.phase = 0;
                // disable everything that isnt used for phase 0:
                this.pumpkinLid.GetComponent<BoxCollider2D>().enabled = false;
                // enable everything that is used for phase 0:
                this.cutHere.GetComponent<BoxCollider2D>().enabled = true;
                break;
            case 1:
                this.phase = 1;
                // disable everything that isnt used for phase 1:
                this.cutHere.GetComponent<BoxCollider2D>().enabled = false;
                // enable everything that is used for phase 1:
                this.pumpkinLid.GetComponent<BoxCollider2D>().enabled = true;
                break;
            case 2:
                this.phase = 2;
                // disable everything that isnt used for phase 2:
                //this.pumpkinLid.GetComponent<BoxCollider2D>().enabled = false;
                this.cutHere.GetComponent<BoxCollider2D>().enabled = false;
                break;
            case 3:
                this.phase = 3;
                break;
            default:
                Debug.LogError("ChangePhaseTo() --> not a valid phase!");
                break;
        }
    }
}
