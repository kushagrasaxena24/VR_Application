﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homedoorscript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		anim.SetTrigger ("opendoor");
	}

	void OnTriggerExit(Collider other)
	{
		anim.enabled = true;
	}

	void pauseAnimationEvent()
	{
		anim.enabled = false;
	}


}