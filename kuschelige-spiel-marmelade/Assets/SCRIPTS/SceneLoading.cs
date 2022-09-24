using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadScene(int index)
    {
        // set cursor to default (just in case)
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

        //load next scene
        SceneManager.LoadScene(index);
    }

    public void closeGame()
    {
        Application.Quit();
    }
}
