using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //everything in scene is GameObject
    private Vector3 offset = new Vector3(0, 4, -12); //assigns variable for update can reuse offset as needed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset; //go to vehicle position, follow with camera
        
    }
}
