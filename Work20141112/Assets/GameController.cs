using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
	private List<GameObject> cameras = new List<GameObject> ();
	private int current_camera_index = 0;
	
	// Use this for initialization
	void Start ()
	{
		var objects = GameObject.FindGameObjectsWithTag ("MainCamera");
		foreach (GameObject game_object in objects)
		{
			if (objects != null)
			{
				cameras.Add (game_object);
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Keypad5))
		{
			//参照カメラ切り替え
			++current_camera_index;
			if (cameras.Count <= current_camera_index)
			{
				current_camera_index = 0;
			}
			for (int i = 0; i < cameras.Count; ++i)
			{
				cameras[i].camera.enabled = i == current_camera_index;
			}
		}
	}
}