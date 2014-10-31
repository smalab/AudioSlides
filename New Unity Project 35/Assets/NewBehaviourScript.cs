using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public float  val;
	public Vector3 ani;
	public AnimationCurve curve;
	// Use this for initialization
	void Start () {
	 	AnimationClip clip = new AnimationClip ();
		//0~3秒の間で5動く
		//AnimationCurve curve = AnimationCurve.Linear (0f, 0f, 3f, 5f);
		//1.5fの時点で7.0fにaddkey
		Keyframe key = new Keyframe (1.5f, 1f);
		curve.AddKey (key);
		val = curve.Evaluate( 1.5f );
	}
	
	// Update is called once per frame
	void Update () {
		GameObject an = GameObject.Find ("anime");
		ani = an.transform.position;
		Debug.Log (ani);

		if(Input.GetKey(KeyCode.Space)){
		ani.x+=val;
		transform.position = new Vector3 (ani.x,0f,-10f);
	}
	}
}
