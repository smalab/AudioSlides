using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class sound1 : MonoBehaviour {

	public int cnt=0;
	public AudioClip slide1;
	public AudioClip slide2;
	public AudioClip slide3;
	public AudioClip slide4;
	public AudioClip slide5;
	public AudioClip slide6;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



	}

	public void rightArrow_Cnt(){
		if (cnt < 7) {
			cnt++;
			slide_sound ();
			return;
		}
	}

	public void leftArrow_Cnt(){
		if (cnt > 0) {
			cnt--;
			slide_sound ();
			return;
		}
	}


	public void slide_sound(){

			if(cnt==2){
			    audio.Stop();
				audio.PlayOneShot(slide1,0.7F);
			}else if(cnt==3){
				audio.Stop ();
				audio.PlayOneShot(slide2,0.7F);
			}else if(cnt==4){
				audio.Stop ();
				audio.PlayOneShot(slide3,0.7F);
			}else if(cnt==5){
				audio.Stop ();
				audio.PlayOneShot(slide4,0.7F);
			}else if(cnt==6){
				audio.Stop ();
				audio.PlayOneShot(slide5,0.7F);
			}else if(cnt==7){
				audio.Stop ();
				audio.PlayOneShot(slide6,0.7F);
			}
		}

	}
