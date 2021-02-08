using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        //vector forward --> (0,0,1)
        //moves car forward, over each frame at a speed of 0.16 
        transform.Translate(Vector3.forward * Time.deltaTime *10);
    }
}
