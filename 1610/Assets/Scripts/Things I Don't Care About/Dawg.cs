﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dawg : Animal {

	// Use this for initialization
	void Awake ()
	{
		print("I am a dog, Dawg");
	}
	
	// Update is called once per frame
	void Update () {
        print("Oh shoot I'm an animal too");
		print("Is this annoying yet?");
	}
}