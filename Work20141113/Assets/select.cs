﻿using UnityEngine;
using System.Collections;

public class select2 : MonoBehaviour {

	public AnimationCurve[] animationCurvePattern = new AnimationCurve[4];//予め設定する値（アニメーションのパターン）0-4で指定
	public  GameObject[] imageArrays = new GameObject[2];//移動先オブジェクト
	public int[] moveAnimationPatterns = new int[4] ;//アニメーションのパターンの順番
	int countObject = -1;//現在のオブジェクトの位置 始めに０番目の地点へ右キーで移動
	
	struct Curve{
		public float height;//基準の高さ
		public float[] keyframeValues;//相対高度
	}
	
	Curve[] curveArray = new Curve[4];

	public AnimationCurve[] animationCurvePatternZoom = new AnimationCurve[1];
	Curve[] curveZoom =new Curve[1];


	void Start () {
		GameObject.Find ("GUI Text").guiText.text = "moveAnimation3 sample";
		Debug.Log(animationCurvePattern[0].Evaluate(animationCurvePattern[0].keys[3].time)+" firstkey"+3);
		Debug.Log(animationCurvePattern[0].Evaluate(0.57f)+" firstkey"+3);
//Evaluateの時間指定が問題  floatでじかんしてい
		GetRelativeHeightsFromAnimationCurvePattern (animationCurvePattern,curveArray);

		if (animationCurvePatternZoom[0].length >= 2) {
			GetRelativeHeightsFromAnimationCurvePattern (animationCurvePatternZoom,curveZoom);
				}

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){	
			if(countObject < imageArrays.Length-1){
				countObject += 1;
				moveAnimation3(imageArrays[countObject].transform.position,moveAnimationPatterns[countObject]);
				Debug.Log (1);
			}
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			if(countObject > 0){
				countObject -=1;
				moveAnimation3(imageArrays[countObject].transform.position, moveAnimationPatterns[countObject]);
				Debug.Log (2);
			}
		}
	}

	
	void GetRelativeHeightsFromAnimationCurvePattern(AnimationCurve[] animationCurvePattern, Curve[] curveArray){
		for (int a=0; a<animationCurvePattern.Length; a++) {
			curveArray [a].keyframeValues = new float[animationCurvePattern [a].length];
		}//長さ確定　インスタンス化
		
		for (int k=0; k<animationCurvePattern.Length; k++) {
			curveArray [k].height = 
				animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[animationCurvePattern [k].length- 1].time) 
					- animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[0].time);
			for (int i=1; i<animationCurvePattern[k].length-1; i++) {
				curveArray [k].keyframeValues [i] = animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[i].time)
					- animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[0].time);
			}//相対高度へ変換
		}//配列curveの各要素の値確定
	}


	void moveAnimation3 (Vector3 targetPosition ,int animationNumber){
		Debug.Log("X");
		AnimationCurve curveX =
			GetAdjustedAnimationCurve(targetPosition.x,gameObject.transform.position.x,animationCurvePattern,animationNumber,curveArray);
		Debug.Log("Y");
		AnimationCurve curveY =
			GetAdjustedAnimationCurve(targetPosition.y,gameObject.transform.position.y,animationCurvePattern,animationNumber,curveArray);
		Debug.Log("Z");
		AnimationCurve curveZ =
			GetAdjustedAnimationCurve(targetPosition.z-2,gameObject.transform.position.z,animationCurvePatternZoom,0,curveZoom);
		Debug.Log("Curvechanged");
		AnimationClip clip3 = new AnimationClip ();
		clip3.SetCurve ("", typeof(Transform), "localPosition.x", curveX);
		clip3.SetCurve ("", typeof(Transform), "localPosition.y", curveY);
		clip3.SetCurve ("", typeof(Transform), "localPosition.z", curveZ);
		animation.AddClip (clip3, "moveclip3");
		animation.Play ("moveclip3");
		
	}

	AnimationCurve GetAdjustedAnimationCurve(float targetPosition,float transformPosition,AnimationCurve[] animationCurvePattern ,int animationNumber ,Curve[] curveArray){

		AnimationCurve curve = new AnimationCurve ();
		curve.keys = animationCurvePattern [animationNumber].keys;
		float distanceToGoAdjusted = (targetPosition - transformPosition) / curveArray [animationNumber].height; //元の幅と変更後の幅の比率

		curve.MoveKey (0,new Keyframe (0, transformPosition));//配列0ばんめのキーフレーム変更
		curve.MoveKey (curve.length - 1, new Keyframe (animationCurvePattern [animationNumber].length - 1, targetPosition) );//終端キーフレーム変更
		Debug.Log (transformPosition+" c.P");
		Debug.Log (targetPosition+" t.P");

		for (int i=1; i<animationCurvePattern[animationNumber].length-1; i++) {
			curve.MoveKey (i, new Keyframe (i, curve.Evaluate (curve.keys[0].time) + curveArray [animationNumber].keyframeValues [i] * distanceToGoAdjusted));
			Debug.Log(animationCurvePattern[animationNumber].Evaluate(curve.keys[i].time)+" firstkey"+i +" anime"+animationNumber);
			Debug.Log(curve.Evaluate (curve.keys[0].time) + curveArray [animationNumber].keyframeValues [i] * distanceToGoAdjusted + " cangedkey"+i);
		}//中間のキーフレーム置き換え

		return curve;

	}
		

}