using UnityEngine;
using System.Collections;

public class select4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void JumpLinear(){
		Application.LoadLevel ("Linear_Section4");
		return;
	}

	public void JumpNonLinear(){
		Application.LoadLevel ("slide4");
		return;
	}
}
