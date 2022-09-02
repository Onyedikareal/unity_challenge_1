using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    public GameObject planeObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Rotate the propeller around it's axis, 
        //vector.forward rotates it around z-direction
        transform.RotateAround(transform.position, planeObject.transform.forward, 1000 * Time.deltaTime);
    }
}
