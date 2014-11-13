using UnityEngine;
using System.Collections;

public class SerialAnimation : MonoBehaviour {
	public AnimationCurve[] AnimationPatterns = new AnimationCurve[4];
    public int[] MoveAnimationPatterns = new int[] { 0,1,2,3 };
	public GameObject[] ImageArrays;// 
	public int currentObject = 0;



	// Use this for initialization
	void Start () {
		moveAnimation(ImageArrays[currentObject].transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && currentObject != 4) {
			Debug.Log ("スペースキー"+currentObject);
			Debug.Log (ImageArrays.Length);
			this.transform.position = new Vector3(ImageArrays[currentObject].transform.position.x,
			                                      ImageArrays[currentObject].transform.position.y,ImageArrays[currentObject].transform.position.z );
			moveAnimation(ImageArrays[currentObject].transform.position);

			Debug.Log ("選択移動");

			currentObject++;
			}
	}


	   void moveAnimation (Vector3 p2){
		AnimationClip clip = new AnimationClip ();
		AnimationCurve curve = new AnimationCurve (AnimationPatterns[MoveAnimationPatterns[currentObject]].keys);	
		Debug.Log ("AnimationPatterns [MoveAnimationPatterns [currentObject]].keys" + AnimationPatterns [MoveAnimationPatterns [currentObject]].keys);
		Debug.Log ("MoveAnimationPatterns [currentObject]" + MoveAnimationPatterns [currentObject]);
		Debug.Log ("currentObject" + currentObject);
		p2.x = AnimationPatterns[MoveAnimationPatterns[currentObject]].Evaluate (currentObject) - 4;
		Debug.Log ("p2.x" + p2.x);
		Debug.Log ("AnimationPatterns[MoveAnimationPatterns[currentObject]].Evaluate (currentObject)" 
		                      		+ AnimationPatterns[MoveAnimationPatterns[currentObject]].Evaluate (currentObject));
		Keyframe testKey = curve[currentObject];
		testKey.time = 2f;
		testKey.value = p2.x;

		Debug.Log ("testKey" + testKey);

		curve.MoveKey (MoveAnimationPatterns[currentObject], testKey);
		clip.SetCurve ("", typeof(Transform), "localPosition.x", curve);
		animation.AddClip (clip, "moveclip2");
		animation.Play ("moveclip2");	
	}

	Keyframe[] AdjustCurve (Keyframe[] keys, float StartPosition ,float EndPosition){
		Keyframe[] returnkey = new Keyframe[4];
		for (int i = 0; i < 4; i++) {
						returnkey [i].value = StartPosition + keys[i].value * (StartPosition - EndPosition) / keys [3].value;
				}
		return returnkey;
	}

}
