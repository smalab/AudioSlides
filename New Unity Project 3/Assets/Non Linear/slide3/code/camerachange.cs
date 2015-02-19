using UnityEngine;
using System.Collections;

public class camerachange : MonoBehaviour {
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
	public int cameracnt = 0;
	
	void Start (){
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
		
		
	}
	
	public void changeCamera1(){
		if (cameracnt == 0) {
			mainCamera.enabled = false;
			camera3_1.enabled = true;
			camera3_2.enabled = false;
			camera3_3.enabled = false;
			camera3_4.enabled = false;
			camera3_5.enabled = false;
			camera3_6.enabled = false;
			camera3_7.enabled = false;
			camera3_8.enabled = false;
			camera3_9.enabled = false;
			cameracnt++;
		}
		return;
	}
	public void changeCamera2(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= true;
		camera3_3.enabled= false;
		camera3_4.enabled= false;
		camera3_5.enabled= false;
		camera3_6.enabled= false;
		camera3_7.enabled= false;
		camera3_8.enabled= false;
		camera3_9.enabled= false;
		cameracnt=2;
		return;
	}
	public void changeCamera3(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= false;
		camera3_3.enabled= true;
		camera3_4.enabled= false;
		camera3_5.enabled= false;
		camera3_6.enabled= false;
		camera3_7.enabled= false;
		camera3_8.enabled= false;
		camera3_9.enabled= false;
		cameracnt=3;
		return;
	}
	public void changeCamera4(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= false;
		camera3_3.enabled= false;
		camera3_4.enabled= true;
		camera3_5.enabled= false;
		camera3_6.enabled= false;
		camera3_7.enabled= false;
		camera3_8.enabled= false;
		camera3_9.enabled= false;
		cameracnt=4;
		return;
	}
	
	public void changeCamera5(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= false;
		camera3_3.enabled= false;
		camera3_4.enabled= false;
		camera3_5.enabled= true;
		camera3_6.enabled= false;
		camera3_7.enabled= false;
		camera3_8.enabled= false;
		camera3_9.enabled= false;
		cameracnt=5;
		return;
	}
	public void changeCamera6(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= false;
		camera3_3.enabled= false;
		camera3_4.enabled= false;
		camera3_5.enabled= false;
		camera3_6.enabled= true;
		camera3_7.enabled= false;
		camera3_8.enabled= false;
		camera3_9.enabled= false;
		cameracnt=6;
		return;
	}
	public void changeCamera7(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= false;
		camera3_3.enabled= false;
		camera3_4.enabled= false;
		camera3_5.enabled= false;
		camera3_6.enabled= false;
		camera3_7.enabled= true;
		camera3_8.enabled= false;
		camera3_9.enabled= false;
		cameracnt=7;
		return;
	}
	public void changeCamera8(){
		mainCamera.enabled = false;
		camera3_1.enabled = false;
		camera3_2.enabled= false;
		camera3_3.enabled= false;
		camera3_4.enabled= false;
		camera3_5.enabled= false;
		camera3_6.enabled= false;
		camera3_7.enabled= false;
		camera3_8.enabled= true;
		camera3_9.enabled= false;
		cameracnt=8;
		return;
	}	
	public void changeCamera9(){
		mainCamera.enabled = false;
		camera3_1.enabled =false;
		camera3_2.enabled= false;
		camera3_3.enabled= false;
		camera3_4.enabled= false;
		camera3_5.enabled= false;
		camera3_6.enabled= false;
		camera3_7.enabled= false;
		camera3_8.enabled= false;
		camera3_9.enabled= true;
		cameracnt=9;
		return;
	}	
	public void cameraBack(){
		if (cameracnt >= 1) {
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
		}
		return;
	}
}