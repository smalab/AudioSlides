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
		transform.position = new Vector3 (422.41f, 256.91f, -600f);
		Debug.Log("back");
	}

}
