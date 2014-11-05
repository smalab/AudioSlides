using UnityEngine;
using System.Collections;

public class myscript : MonoBehaviour {
	//public bool situation;
	//public bool situation1;
	//public bool situation2;
	//public bool situation3;
	//public AnimationClip clipA;
	public AnimationCurve curveA;
	//public AnimationClip clipB;
	public AnimationCurve curveB;
	public int flag = 0;
	public int flag1 = 0;
	// Use this for initialization
	void Start () {
		GameObject.Find ("GUI Text").guiText.text = "anim1";
		
		//first
		//clipA = new AnimationClip ();
		AnimationClip clipA = new AnimationClip ();
		//AnimationCurve curveA = AnimationCurve.Linear (0f, 3f, 3f, 3f);
		//Keyframe keyA = new Keyframe (1.5f, 10f);
		//curveA.AddKey (keyA);
		clipA.SetCurve ("", typeof(Transform), "localPosition.z", curveA);
		clipA.wrapMode = WrapMode.Once;
		animation.AddClip (clipA, "anim1");
		//animation.Play ("anim1");
		//situation = animation.isPlaying;
		//Debug.Log (situation + "situation");
		//animation.Stop();
		//situation1 = animation.isPlaying;
		//Debug.Log (situation1 + "situation1");
		//if((animation.IsPlaying("anim1")){
		//animation.Play ("clip1");
		
		//second
		//clipB = new AnimationClip ();
		AnimationClip clipB = new AnimationClip ();
		//AnimationCurve curveB = AnimationCurve.Linear (0f, 3f, 3f, 3f);
		/*Keyframe key1 = new Keyframe (0.75f, 7f);
		curveB.AddKey (key1);
		Keyframe key2 = new Keyframe (1.5f, 3f);
		curveB.AddKey (key2);
		Keyframe key3 = new Keyframe (2.25f, 7f);
		curveB.AddKey (key3);*/
		clipB.SetCurve ("", typeof(Transform), "localPosition.z", curveB);
		clipB.wrapMode = WrapMode.Once;
		animation.AddClip (clipB, "anim2");
		animation.Play ("anim1");
		//situation2 = animation.isPlaying;
		//Debug.Log (situation2 + "situation2");
		//animation.Stop();
		//situation3 = animation.isPlaying;
		//Debug.Log (situation3 + "situation3");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (1f, 1f, 1f);
		if(animation.IsPlaying("anim1")==false){
			flag = 1;
			Debug.Log (flag+"あ");
			//new WaitForSeconds(5.0f);
			if(Input.GetKeyDown(KeyCode.Space)){
				flag1 = 1;
				animation.PlayQueued ("anim2",QueueMode.PlayNow);
				GameObject.Find("GUI Text").guiText.text = "Anim2!";
			}
			}else{
			//animation.PlayQueued("anim1",QueueMode.PlayNow);
			//GameObject.Find ("GUI Text").guiText.text = "Anim1!";

			flag = 0;
			flag1 = 0;
			Debug.Log (flag + "い");
		}
	}
}





