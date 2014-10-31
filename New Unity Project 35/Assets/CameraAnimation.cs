using UnityEngine;
using System.Collections;

public class CameraAnimation : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		Debug.Log("a");
		AnimationClip clip = new AnimationClip ();
		AnimationCurve curve = AnimationCurve.Linear (0f, 0f, 3f, 10f);
		Keyframe key = new Keyframe (1.5f, 7f);
		curve.AddKey (key);
		clip.SetCurve ("", typeof(Transform), "localPosition.x", curve);
		clip.wrapMode = WrapMode.Loop;
		animation.AddClip (clip, "clip1");
		animation.Play ("clip1");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			animation.Stop ();
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			animation.Play ("clip1");
		}
	}
}
