using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacciones : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int code;
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.enabled = false;
    }

    
    void OnMouseOver()
        {
            this.spriteRenderer.enabled = true;
           
            if (Input.GetMouseButtonDown(0))
            {

            }
        

        }
        void OnMouseExit()
        {
            this.spriteRenderer.enabled = false;
            
        }
    
}
