using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class target : MonoBehaviour {
	public int cnt=2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void slide_click() {
		transform.position = new Vector3 (0f, 0f, -2.844865f);
		cnt++;
		return;
	}

	public void slidesound(){
			audio.Play();
		return;
		}

	public void soundend(){
		audio.Stop ();
		}


}
