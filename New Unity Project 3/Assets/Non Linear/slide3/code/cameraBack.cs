using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraBack : MonoBehaviour {
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
	
	public int cnt=0;
	

	
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
	

	public void cameraBackHome(){
		if (camera3_1.enabled | camera3_2.enabled | camera3_3.enabled | camera3_4.enabled | camera3_5.enabled | camera3_6.enabled | camera3_7.enabled | camera3_8.enabled | camera3_9.enabled) {
			mainCamera.enabled = true;

			cnt = 0;
			Debug.Log (cnt);
		}
		
	}
}