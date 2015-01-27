using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class target_slide7 : MonoBehaviour {
	public int cnt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void slide_click() {
		transform.position = new Vector3 (765f, 345f, -120f);
		cnt=7;
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
