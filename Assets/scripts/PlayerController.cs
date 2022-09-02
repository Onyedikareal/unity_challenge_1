using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed =45.0f;
    private float horizontalInput;
    private float forwardInput ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //Input is from Input manager in the Edit>ProjectSettings>Input Manager and is used to controll the axis of the player using keyboard arrows or specified keys in the project settings 
        //Here we are controlling the horizontal Axis
        forwardInput = Input.GetAxis("Vertical"); // for getting the vertical axis controll
        //move the vehicle forward
        transform.Translate(Vector3.forward* Time.deltaTime*speed * forwardInput);
        //We turn the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

       
    }
}
