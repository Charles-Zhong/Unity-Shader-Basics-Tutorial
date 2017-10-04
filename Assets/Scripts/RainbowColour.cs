﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowColour : MonoBehaviour {

	//References to render and material
	Renderer rend;
	Material material;

	// Use this for initialization
	void Start () {
		//Get references,
		rend = GetComponent<Renderer>();
		material = rend.material;

		//Set shader value with name "_Colour" to Color.magenta
		material.SetColor("_Colour", Color.magenta);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
