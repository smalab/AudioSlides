﻿using UnityEngine;
using System.Collections;

public class targetSlide2_5 : MonoBehaviour {
	public int cnt=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void slide_click() {
		if (cnt == 0) {
			transform.position = new Vector3 (270f, 200f, -205f);
			cnt++;
		} else {
			transform.position = new Vector3 (-0f, -1f, -1000f);
			cnt--;
		}
		return;
	}
	
	public void slidesound(){
		if (cnt == 0) {
			audio.Stop ();
			audio.Play ();
			cnt++;
		} else {
			audio.Stop ();
			cnt--;
		}
		return;
	}
}