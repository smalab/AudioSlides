using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	Animation animation;


	// ゲーム初期化処理
	void Start () {
		animation = GetComponent<Animation>();
	}
	
	// frameごとに呼び出される
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			animation.Play ("camera_move_right");
				}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			animation.Play ("camera_move_left");
		}

		}
	}
