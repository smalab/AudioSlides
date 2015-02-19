using UnityEngine;
using System.Collections;

public class select3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void JumpLinear(){
		Application.LoadLevel ("Linear_Section3");
		return;
	}

	public void JumpNonLinear(){
		Application.LoadLevel ("slide3");
		return;
	}
}
