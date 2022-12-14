using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseManager : MonoBehaviour
{
    public AudioSource kniveNoise;
    public AudioSource spoonNoise;
    public AudioSource[] scoopingNoise;
    public AudioSource[] carvingNoise;
    public AudioSource[] bowlNoise;
    public AudioSource plopSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayKniveNoise()
    {
        this.kniveNoise.Play();
    }

    public void PlaySpoonNoise()
    {
        this.spoonNoise.Play();
    }

    public void PlayPlopNoise()
    {
        this.plopSound.Play();
    }

    public void PlayScoopingNoise()
    {
        //plays random sooping noise from list
        if(this.scoopingNoise.Length > 0)
        {
            this.scoopingNoise[Random.Range(0, this.scoopingNoise.Length)].Play();
        }
    }

    public void PlayBowlNoise()
    {
        //plays random bowl noise from list
        if (this.bowlNoise.Length > 0)
        {
            this.bowlNoise[Random.Range(0, this.bowlNoise.Length)].Play();
        }
    }

    public void PlayCarvingNoise()
    {
        //plays random carving noise from list
        if (this.carvingNoise.Length > 0)
        {
            this.carvingNoise[Random.Range(0, this.carvingNoise.Length)].Play();
        }
    }
}
