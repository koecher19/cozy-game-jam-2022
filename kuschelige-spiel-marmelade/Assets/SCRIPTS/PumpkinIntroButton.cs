using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PumpkinIntroButton : MonoBehaviour
{
    public Spawner spawner;
    public GameObject BlazeButtonReference;
    public GameObject HimboButtonReference;
    public GameObject TsundaraButtonReference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnPumpkinPress(Spawner.Pumpkins choosenPumpkin)
    {
        this.spawner.chooosenPumpkin = choosenPumpkin;
        this.spawner.SpawnSpeechbubble();
        this.GetComponent<Button>().interactable = false;
    }
    public void OnPumpkinPressBlaze()
    {
        OnPumpkinPress(Spawner.Pumpkins.BLAZE);
        HimboButtonReference.GetComponent<Button>().interactable = false;
        TsundaraButtonReference.GetComponent<Button>().interactable = false;
    }
    public void OnPumpkinPressHimbo()
    {
        OnPumpkinPress(Spawner.Pumpkins.HIMBO);
        BlazeButtonReference.GetComponent<Button>().interactable = false;
        TsundaraButtonReference.GetComponent<Button>().interactable = false;
    }
    public void OnPumpkinPressTsundara()
    {
        OnPumpkinPress(Spawner.Pumpkins.TSUNDARA);
        BlazeButtonReference.GetComponent<Button>().interactable = false;
        HimboButtonReference.GetComponent<Button>().interactable = false;
    }
}
