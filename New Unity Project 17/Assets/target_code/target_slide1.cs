﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class target_slide1 : MonoBehaviour {
	public int cnt=2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void slide_click() {
		transform.position = new Vector3 (167f, 180f, -120f);
		cnt=1;
		return;
	}

	public void slidesound(){
		audio.Stop ();
		audio.Play();
		return;
	}

}
