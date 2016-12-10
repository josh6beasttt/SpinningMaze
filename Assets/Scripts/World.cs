using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

    public GameObject player;


	// Use this for initialization
	void Start () {

	}

	void Update(){

        transform.Rotate(new Vector3(-10, 0, 0) * Time.deltaTime);

	}
	// Update is called once per frame
	void FixedUpdate () {
        //transform.Rotate(new Vector3(-10, 0, 0) * Time.deltaTime);
        //print(transform.up);
        player.GetComponent<Rigidbody>().AddForce(transform.up * -9.8f);
	}
}