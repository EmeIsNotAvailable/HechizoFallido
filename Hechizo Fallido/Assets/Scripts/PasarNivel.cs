using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarNivel : MonoBehaviour
{
    public int nivel;
    public bool apretao=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(apretao)
        {
            SceneManager.LoadScene(nivel);
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            apretao = true;
        }
        Debug.Log("Mouse is over GameObject.");
    }
}
