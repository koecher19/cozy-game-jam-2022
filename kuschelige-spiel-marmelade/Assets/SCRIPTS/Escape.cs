using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            // press esc any time to return to the main menu
            // diable special cursor
            /*
            if (SceneManager.GetActiveScene().name == "CARVING")
            {
                if (GameObject.Find("KniveManager").GetComponent<KniveManager>().isKnivePickedUp)
                {
                    GameObject.Find("KniveManager").GetComponent<KniveManager>().PickupPutdownKnive();
                }
            }else if(SceneManager.GetActiveScene().name == "SPOONING")
            {
                GameObject.Find("ButtonManager").GetComponent<ButtonManager>().ChangeCursorToDefault();
            }
            */

            // set cursor to default (just in case)
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

            GetComponent<SceneLoading>().loadScene(0);
        }
    }
}
