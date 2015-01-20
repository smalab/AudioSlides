using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class target_slide4 : MonoBehaviour {
	public int cnt=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void slide_click() {
		transform.position = new Vector3 (20f, 0f, -2.844865f);
		cnt=4;
		return;
	}
	
	public void slidesound(){
		audio.Stop ();
		audio.Play();
		return;
	}
	
}
