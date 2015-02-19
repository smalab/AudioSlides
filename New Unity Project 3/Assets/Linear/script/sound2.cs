using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class sound2 : MonoBehaviour {
	
	public int cnt=0;
	public AudioClip slide01;
	public AudioClip slide02;
	public AudioClip slide03;
	public AudioClip slide04;
	public AudioClip slide05;
	public AudioClip slide06;
	public AudioClip slide07;
	public AudioClip slide08; 
	public AudioClip slide09;
	public AudioClip slide10;
	public AudioClip slide11;
	public AudioClip slide12;
	AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	
	public void rightArrow_Cnt(){
		if (cnt < 12) {
			cnt++;
			slide_sound ();
			return;
		}
	}
	
	public void leftArrow_Cnt(){
		if (cnt > 1) {
			cnt--;
			slide_sound ();
			return;
		}
	}
	
	
	public void slide_sound(){
		
				if (cnt == 1) {
						audio.Stop ();
						audioSource.clip = slide01;
						audioSource.PlayDelayed (3.0f);				
				} else if (cnt == 2) {
						audio.Stop ();
						audioSource.clip = slide02;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 3) {
						audio.Stop ();
						audioSource.clip = slide03;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 4) {
						audio.Stop ();
						audioSource.clip = slide04;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 5) {
						audio.Stop ();
						audioSource.clip = slide05;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 6) {
						audio.Stop ();
						audioSource.clip = slide06;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 7) {
						audio.Stop ();
						audioSource.clip = slide07;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 8) {
						audio.Stop ();
						audioSource.clip = slide08;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 9) {
						audio.Stop ();
						audioSource.clip = slide09;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 10) {
						audio.Stop ();
						audioSource.clip = slide07;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 11) {
						audio.Stop ();
						audioSource.clip = slide08;
						audioSource.PlayDelayed (2.0f);
				} else if (cnt == 12) {
						audio.Stop ();
						audioSource.clip = slide09;
						audioSource.PlayDelayed (2.0f);
				}
		}
	
	public void slide_click() {
		transform.position = new Vector3 (0f, 0f, -2.844865f);
		cnt=1;
		return;
	}
	
	public void slideSound1(){
		cnt = 0;
		slide_sound ();
		return;
	}
	
	public void soundEnd1(){
		audio.Stop ();
		cnt = 0;
	}
	
}
