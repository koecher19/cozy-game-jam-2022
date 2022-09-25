using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
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
    public Pumpkins pumpkin;
    public enum Pumpkins{
        BLAZE = 0,
        HIMBO = 1,
        TSUNDARA = 2
    }
    // Start is called before the first frame update
    void Start()
    {
            SpawnPosition = SpawnLocationObjects[((int)pumpkin)].transform.position;
            SpawnRotation = SpawnLocationObjects[((int)pumpkin)].transform.rotation;
            Instantiate(ObjectsToSpawn[((int)pumpkin)], SpawnPosition, SpawnRotation, SpawnParent.transform) ;
            AudioSource.PlayClipAtPoint(ListOfSpeechSounds[((int)pumpkin)], SpawnPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
