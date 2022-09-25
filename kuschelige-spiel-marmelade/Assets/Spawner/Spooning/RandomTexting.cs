using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomTexting : MonoBehaviour
{
    public float timeTillDisappearing;
    private float currentTimeUntilDisappearing;
    private TextMeshProUGUI Speechbubble;
    public List<string> StringList;
    private int IDCurrentTextDisplayed = 0;
    private bool randomOutput = false;
    public GameObject parentObjectToDisappear;
    [Header("Spawner Reference")]
    public Spawner spawner;


    // Start is called before the first frame update
    void Start()
    {
        currentTimeUntilDisappearing = timeTillDisappearing;
        this.Speechbubble = this.GetComponent<TextMeshProUGUI>();
        this.Speechbubble.text = StringList[Random.Range(0,StringList.Count)];
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

        if(currentTimeUntilDisappearing > 0)
        {
            this.currentTimeUntilDisappearing -= Time.deltaTime;
        }
        else
        {
            parentObjectToDisappear.SetActive(false);
        }/*
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            parentObjectToDisappear.SetActive(false);
        }*/
    }
}
