using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug2 : MonoBehaviour
{

    public bool didSlowed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(didSlowed){
            SlowDown();
        }
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
    }

    void SlowDown(){
        didSlowed = false;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
