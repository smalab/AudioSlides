using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class target_slide3 : MonoBehaviour {
	public int cnt=0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void slide_click() {
		transform.position = new Vector3 (20f, 10f, -2.844865f);
		cnt=3;
		Debug.Log("3");
		return;
	
	}
	
	public void slidesound(){
		audio.Stop ();
		audio.Play();
		return;
	}
	
	public void soundend(){
		audio.Stop ();
		cnt = 0;
	}
	
	
}
