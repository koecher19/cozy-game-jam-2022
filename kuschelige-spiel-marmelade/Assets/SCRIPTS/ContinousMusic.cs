using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousMusic : MonoBehaviour
{
    AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        this.audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (this.audioSource.isPlaying) return;
        this.audioSource.Play();
    }

    public void StopMusic()
    {
        this.audioSource.Stop();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
