using UnityEngine;
using System.Collections;

public class cameraback : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void camera_back(){
			transform.position = new Vector3 (30f, 5f, -45f);
	}
}
