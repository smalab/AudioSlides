using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class target_slide5 : MonoBehaviour {
	public int cnt=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void slide_click() {
		transform.position = new Vector3 (540f, 345f, -120f);
		cnt=5;
		Debug.Log (cnt);
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
