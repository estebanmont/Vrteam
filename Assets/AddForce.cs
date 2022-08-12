using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField]GameObject mySelf;
    Rigidbody myBody;
    private void Start()
    {
        myBody = mySelf.GetComponent<Rigidbody>(); 
    }
   public void shoot()
    {
        myBody.AddForce(force);
    }
}
