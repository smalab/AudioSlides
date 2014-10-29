using UnityEngine;
using System.Collections;

public class CameraAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AnimationClip clip = new AnimationClip ();
		AnimationCurve curve = AnimationCurve.Linear (0f, 3f, 3f, 3f);
		Keyframe key = new Keyframe (1.5f, 7f);
		curve.AddKey (key);
		clip.SetCurve ("", typeof(Transform), "localPosition.z", curve);
		clip.wrapMode = WrapMode.Default;
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
