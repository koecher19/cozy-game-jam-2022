using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderOnHover : MonoBehaviour
{
    Material material;

    bool isHoveredOver = true;
    float fade = 1f;
    
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isHoveredOver = !isHoveredOver;
        }
// && fade !<= 0f
        if (!isHoveredOver)
        {
            fade -= Time.deltaTime;

            if(fade <= 0f)
            {
                fade = 0f;
            }
            material.SetFloat("_Thicknes", fade);
        }

    }

    public void OnButtonCursorEnter()
    {
        material.SetFloat("_Thicknes", 1f);
    }
    public void OnButtonCursorExit()
    {
        fade = 1f;
    }                         
}
