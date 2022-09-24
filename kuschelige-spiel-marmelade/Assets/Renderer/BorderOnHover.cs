using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorderOnHover : MonoBehaviour
{
    Material material;

    bool isHoveredOver;
    public float fade;
    
    void Start()
    {
        this.fade = 0f;
        this.isHoveredOver = false;
        this.material = this.GetComponent<Image>().material;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.isHoveredOver == false)
        {
            this.fade -= Time.deltaTime*2;

            if(fade <= 0f)
            {
                fade = 0f;
                isHoveredOver = false;
            }
            this.material.SetFloat("_Thicknes", fade);
        }

    }

    public void OnButtonCursorEnter()
    {
        this.isHoveredOver = true;
        this.material.SetFloat("_Thicknes", 1f);
    }
    public void OnButtonCursorExit()
    {
        this.isHoveredOver = false;
        this.fade = 1f;
    }                         
}
