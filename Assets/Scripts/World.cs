﻿using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(-10, 0, 0) * Time.deltaTime);
	}
}