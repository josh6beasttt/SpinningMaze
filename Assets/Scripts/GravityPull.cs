using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPull : MonoBehaviour {

 
	public GameObject attractedTo;
    public float strengthOfAttraction;
    //public RigidBody rb;
     
    void FixedUpdate (){
        Vector3 direction = attractedTo.transform.position - transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce (strengthOfAttraction * direction);
         
    }
 }
