using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movbrujita : MonoBehaviour
{
    float x;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * vel * Time.deltaTime;
        transform.Translate(x, 0, 0);
        if (x < 0)
            transform.localScale = new Vector2(-1, 1);
        else if(x!=0)
            transform.localScale = new Vector2(1, 1);
    }
}
