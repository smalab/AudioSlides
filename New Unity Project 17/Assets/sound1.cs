using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class sound1 : MonoBehaviour {

	public int cnt=0;
	public AudioClip Kalimba;
	public AudioClip battle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



	}

	public void rightArrow_Cnt(){
		cnt++;
		slide_sound ();
		return;
		}

	public void leftArrow_Cnt(){
		cnt--;
		slide_sound ();
		return;

		}


	public void slide_sound(){

			if(cnt==2){
			audio.PlayOneShot (Kalimba,0.7F);
			}else if(cnt==3){
				audio.Stop ();
				audio.PlayOneShot (battle);
			}
		}
}
