using UnityEngine;
using System.Collections;

public class JumpSection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void jump1(){
		Application.LoadLevel ("Section1");
		return;
	}

	public void jump2(){
		Application.LoadLevel ("Section2");
		return;
	}

	public void jump3(){
		Application.LoadLevel ("Section3");
		return;
	}

	public void jump4(){
		Application.LoadLevel ("Section4");
		return;
	}

	public void jump5(){
		Application.LoadLevel ("Section5");
		return;
	}
}
