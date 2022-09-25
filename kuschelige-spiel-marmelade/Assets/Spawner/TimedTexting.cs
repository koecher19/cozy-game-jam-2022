using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimedTexting : MonoBehaviour
{
    public float timeTillChange;
    private float currentTimeUntilChange;
    private TextMeshProUGUI Speechbubble;
    public List<string> StringList;
    private int IDCurrentTextDisplayed = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        currentTimeUntilChange = timeTillChange;
        this.Speechbubble = this.GetComponent<TextMeshProUGUI>();
        this.Speechbubble.text = StringList[IDCurrentTextDisplayed];
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

        if(currentTimeUntilChange > 0)
        {
            this.currentTimeUntilChange -= Time.deltaTime;
        }
        else
        {
            nextAction();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            nextAction();
        }
    }
    private void nextAction()
    {
        if (IDCurrentTextDisplayed < StringList.Count)
        {
            this.Speechbubble.text = StringList[IDCurrentTextDisplayed];
            IDCurrentTextDisplayed++;
            this.currentTimeUntilChange = this.timeTillChange;
        }
        else
        {
            //this.GetComponent<SceneLoading>().loadScene;
        }
    }
}
