using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{
    public GameObject BlowerObject;
    public Vector3 Ball;
    public Vector3 Blower;
    public int force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Blower = BlowerObject.transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Debug.Log("calisiyom");
        Ball = other.transform.position;
        Vector3 rDirection = other.transform.position - Blower;
        Vector3 nDirection = rDirection.normalized;
        other.GetComponent<Rigidbody>().AddForce(nDirection * force);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("ball")){
            other.GetComponent<Debug2>().didSlowed = true;
        }
        other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, 0);
    }
}

