using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSceneSript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // play background music
        GameObject.FindGameObjectWithTag("Music").GetComponent<ContinousMusic>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
