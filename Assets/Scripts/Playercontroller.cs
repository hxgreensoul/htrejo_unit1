using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private float speed = 15.0f; //decimal value for speed
    private float turnSpeed = 15.0f; //decimal value for turning speed

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // assigns variable to go side to side
        verticalInput = Input.GetAxis("Vertical"); // assigns variable to rotate

        Debug.Log(Time.deltaTime); 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); //makes car rotate
    }
}
