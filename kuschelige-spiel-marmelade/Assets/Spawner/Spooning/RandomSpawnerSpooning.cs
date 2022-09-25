using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerSpooning : MonoBehaviour
{
    [Header("Spawn Object")]
    public List<GameObject> ObjectsToSpawn;
    [Header("Spawn Locations")]
    public List<GameObject> SpawnLocationObjects;
    private Vector3 SpawnPosition;
    private Quaternion SpawnRotation;
    [Header("Spawn Locations")]
    public List<AudioClip> ListOfSpeechSounds;
    [Header("Target Canvas")]
    public GameObject SpawnParent;
    [Header("Logical Operator")]
    public Pumpkins chooosenPumpkin;
    public bool test = false;
    public enum Pumpkins
    {
        BLAZE = 0,
        HIMBO = 1,
        TSUNDARA = 2
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            SpawnSpeechbubble();
        }
    }

    public void SpawnSpeechbubble()
    {
            SpawnPosition = SpawnLocationObjects[((int)chooosenPumpkin)].transform.position;
            SpawnRotation = SpawnLocationObjects[((int)chooosenPumpkin)].transform.rotation;
            Instantiate(ObjectsToSpawn[((int)chooosenPumpkin)], SpawnPosition, SpawnRotation, SpawnParent.transform);
    }
}
