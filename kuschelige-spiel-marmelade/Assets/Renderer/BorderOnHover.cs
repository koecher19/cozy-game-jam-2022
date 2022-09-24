using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorderOnHover : MonoBehaviour
{
    Material material;

    private bool isHoveredOver = true;
    private float fade;
    
    void Start()
    {
        this.fade = 0f;
        this.material = this.GetComponent<Image>().material;
    }

    // Update is called once per frame _
    void Update()
    {

        if (!this.isHoveredOver)
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
        this.material.SetFloat("_Thicknes", 2);
    }
    public void OnButtonCursorExit()
    {
        this.isHoveredOver = false;
        this.fade = 2f;
    }                         
}
