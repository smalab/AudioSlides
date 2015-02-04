using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void rightArrowmoveZ(){
		pos.z = 120f;
		transform.position = pos;
		return;
	}


}
