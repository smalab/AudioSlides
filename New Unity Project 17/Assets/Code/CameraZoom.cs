﻿using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
						if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
								float zoom = Input.GetAxisRaw ("Vertical");
								transform.Translate (0, 0, zoom*0.1f);
						}
	}
}
