﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
