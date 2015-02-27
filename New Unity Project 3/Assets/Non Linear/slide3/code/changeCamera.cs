using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeCamera : MonoBehaviour {
Camera mainCamera;//メインカメラ
Camera camera3_1;//サブのカメラです
Camera camera3_2;//サブのカメラです
Camera camera3_3;//サブのカメラです
Camera camera3_4;//サブのカメラです
Camera camera3_5;//サブのカメラです
Camera camera3_6;//サブのカメラです
Camera camera3_7;//サブのカメラです
Camera camera3_8;//サブのカメラです
Camera camera3_9;//サブのカメラです
Camera camera3_10;

public int cnt=0;

public AudioClip slide3_1;
public AudioClip slide3_2;
public AudioClip slide3_3;
public AudioClip slide3_4;
public AudioClip slide3_5;
public AudioClip slide3_6;
public AudioClip slide3_7;
public AudioClip slide3_8; 
public AudioClip slide3_9;

AudioSource audioSource;

void Start (){
	audioSource = gameObject.GetComponent<AudioSource>();
	mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
	camera3_1 = GameObject.Find ("Camera3_1").GetComponent<Camera> ();
	camera3_2 = GameObject.Find ("Camera3_2").GetComponent<Camera> ();
	camera3_3 = GameObject.Find ("Camera3_3").GetComponent<Camera> ();
	camera3_4 = GameObject.Find ("Camera3_4").GetComponent<Camera> ();
	camera3_5 = GameObject.Find ("Camera3_5").GetComponent<Camera> ();
	camera3_6 = GameObject.Find ("Camera3_6").GetComponent<Camera> ();
	camera3_7 = GameObject.Find ("Camera3_7").GetComponent<Camera> ();
	camera3_8 = GameObject.Find ("Camera3_8").GetComponent<Camera> ();
	camera3_9 = GameObject.Find ("Camera3_9").GetComponent<Camera> ();
	camera3_10 = GameObject.Find ("Camera3_10").GetComponent<Camera> ();

	mainCamera.enabled = true;
	camera3_1.enabled = false;
	camera3_2.enabled = false;
	camera3_3.enabled = false;
	camera3_4.enabled = false;
	camera3_5.enabled = false;
	camera3_6.enabled = false;
	camera3_7.enabled = false;
	camera3_8.enabled = false;
	camera3_9.enabled = false;
	camera3_10.enabled = false;

	
}

void Update () {
	// Spaceキーで切り替え
	if (Input.GetKeyDown (KeyCode.Space)) {
			if (mainCamera.enabled) {
				mainCamera.enabled = false;
				camera3_1.enabled = true;
				camera3_10.enabled = true;
				cnt=1;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_1.enabled) {
				camera3_1.enabled = false;
				camera3_2.enabled = true;
				camera3_10.enabled = true;
				cnt=2;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_2.enabled) {
				camera3_2.enabled = false;
				camera3_3.enabled = true;
				camera3_10.enabled = true;
				cnt=3;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_3.enabled) {
				camera3_3.enabled = false;
				camera3_4.enabled = true;
				camera3_10.enabled = true;
				cnt=4;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_4.enabled) {
				camera3_4.enabled = false;
				camera3_5.enabled = true;
				camera3_10.enabled = true;
				cnt=5;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_5.enabled) {
				camera3_5.enabled = false;
				camera3_6.enabled = true;
				camera3_10.enabled = true;
				cnt=6;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_6.enabled) {
				camera3_6.enabled = false;
				camera3_7.enabled = true;
				camera3_10.enabled = true;
				cnt=7;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_7.enabled) {
				camera3_7.enabled = false;
				camera3_8.enabled = true;
				camera3_10.enabled = true;
				cnt=8;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_8.enabled) {
				camera3_8.enabled = false;
				camera3_9.enabled = true;
				camera3_10.enabled = true;
				cnt=9;
				Debug.Log (cnt);
				slide_sound ();
			} else if (camera3_9.enabled) {
				mainCamera.enabled = true;
				camera3_9.enabled = false;
				camera3_10.enabled = false;
				cnt=0;
				Debug.Log (cnt);
				audio.Stop();
			}

		} else if (Input.GetKeyDown (KeyCode.Tab)) {
			mainCamera.enabled = true;
			camera3_1.enabled = false;
			camera3_2.enabled = false;
			camera3_3.enabled = false;
			camera3_4.enabled = false;
			camera3_5.enabled = false;
			camera3_6.enabled = false;
			camera3_7.enabled = false;
			camera3_8.enabled = false;
			camera3_9.enabled = false;
			camera3_10.enabled = false;
			cnt=0;
			audio.Stop();
		}
  }
	public void slide_sound(){
		
		if (cnt == 1) {
			audio.Stop ();
			audioSource.clip = slide3_1;
			audioSource.PlayDelayed (2.0f);				
		} else if (cnt == 2) {
			audio.Stop ();
			audioSource.clip = slide3_2;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 3) {
			audio.Stop ();
			audioSource.clip = slide3_3;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 4) {
			audio.Stop ();
			audioSource.clip = slide3_4;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 5) {
			audio.Stop ();
			audioSource.clip = slide3_5;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 6) {
			audio.Stop ();
			audioSource.clip = slide3_6;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 7) {
			audio.Stop ();
			audioSource.clip = slide3_7;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 8) {
			audio.Stop ();
			audioSource.clip = slide3_8;
			audioSource.PlayDelayed (2.0f);
		} else if (cnt == 9) {
			audio.Stop ();
			audioSource.clip = slide3_9;
			audioSource.PlayDelayed (2.0f);
		}

     }


	public void changeCamera1(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_1.enabled = true;
			camera3_10.enabled = true;
			cnt++;
			slide_sound ();
		} else if (camera3_1.enabled) {
			mainCamera.enabled=true;
			camera3_1.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	public void changeCamera2(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_2.enabled = true;
			camera3_10.enabled = true;
			cnt = 2;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_2.enabled) {
			mainCamera.enabled=true;
			camera3_2.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	public void changeCamera3(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_3.enabled = true;
			camera3_10.enabled = true;
			cnt = 3;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_3.enabled) {
			mainCamera.enabled=true;
			camera3_3.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	public void changeCamera4(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_4.enabled = true;
			camera3_10.enabled = true;
			cnt = 4;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_4.enabled) {
			mainCamera.enabled=true;
			camera3_4.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	
	public void changeCamera5(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_5.enabled = true;
			camera3_10.enabled = true;
			cnt = 5;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_5.enabled) {
			mainCamera.enabled=true;
			camera3_5.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	public void changeCamera6(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_6.enabled = true;
			camera3_10.enabled = true;
			cnt = 6;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_6.enabled) {
			mainCamera.enabled=true;
			camera3_6.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	public void changeCamera7(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_7.enabled = true;
			camera3_10.enabled = true;
			cnt = 7;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_7.enabled) {
			mainCamera.enabled=true;
			camera3_7.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}
	public void changeCamera8(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_8.enabled = true;
			camera3_10.enabled = true;
			cnt = 8;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_8.enabled) {
			mainCamera.enabled=true;
			camera3_8.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}	
	public void changeCamera9(){
		if (mainCamera.enabled & cnt == 0) {
			mainCamera.enabled = false;
			camera3_9.enabled = true;
			camera3_10.enabled = true;
			cnt = 9;
			slide_sound ();
			Debug.Log (cnt);
		} else if (camera3_9.enabled) {
			mainCamera.enabled=true;
			camera3_9.enabled=false;
			camera3_10.enabled = false;
			cnt = 0;
			audio.Stop();
			Debug.Log (cnt);
		}

	}	
	
}