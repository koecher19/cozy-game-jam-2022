using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpeechbubblesAtRandomIntervall : MonoBehaviour
{
    public RandomSpawnerSpooning randomSpawnerSpooning;
    public float minWait;
    public float maxWait;

    private bool isSpawning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        this.isSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isSpawning)
        {
            float timer = Random.Range(minWait, maxWait);
            Invoke("SpawnObject", timer);
            this.isSpawning = true;
        }
    }

    void SpawnObject()
    {
        // Code to spawn your prefab here
        this.randomSpawnerSpooning.SpawnSpeechbubble();
        this.isSpawning = false;
    }
}
