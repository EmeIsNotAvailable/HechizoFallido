using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnMouseOver()
    {
        transform.localScale = new Vector2(1.2f, 1.2f);

        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
            Debug.Log("salio del juego");
        }
        
    }
    void OnMouseExit()
    {
        transform.localScale = new Vector2(1, 1);
    }
}
