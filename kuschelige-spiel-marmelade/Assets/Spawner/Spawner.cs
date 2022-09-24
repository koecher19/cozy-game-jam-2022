using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public GameObject SpawnLocation;
    public enum Pumpkins{
        BLAZE = 1,
        HIMBO = 2,
        TSUNDARA = 3
    }
    // Start is called before the first frame update
    void Start()
    {
        Pumpkins choosenPumpkin = Pumpkins.BLAZE;
        if(choosenPumpkin == Pumpkins.BLAZE)
        {
            Instantiate(ObjectToSpawn,SpawnLocation.transform,SpawnLocation.transform);
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
