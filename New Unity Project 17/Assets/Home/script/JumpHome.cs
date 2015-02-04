using UnityEngine;
using System.Collections;

public class JumpHome : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Home(){
		Application.LoadLevel ("Home");
		return;
	}
}
