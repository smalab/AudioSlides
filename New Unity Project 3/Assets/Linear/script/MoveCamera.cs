using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour {
	
	public AnimationCurve[] animationCurvePattern = new AnimationCurve[1];//予め設定する値（アニメーションのパターン）0-4で指定
	public  GameObject[] imageArrays = new GameObject[7];//移動先オブジェクト
	public int[] moveAnimationPatterns = new int[7] ;//アニメーションのパターンの順番
	int countObject = -1;//現在のオブジェクトの位置 始めに０番目の地点へ右キーで移動
	
	struct Curve{
		public float height;//基準の高さ
		public float[] keyframeValues;//相対高度
	}
	
	Curve[] curveArray = new Curve[7];
	
	public AnimationCurve[] animationCurvePatternZoom = new AnimationCurve[1];
//	Curve[] curveZoom =new Curve[1];
	

	
	void Start () {
		
		GetRelativeHeightsFromAnimationCurvePattern (animationCurvePattern,curveArray);
		//if (animationCurvePatternZoom.Length >= 1) {
		//	if (animationCurvePatternZoom [0].length >= 2) {
		//		GetRelativeHeightsFromAnimationCurvePattern (animationCurvePatternZoom, curveZoom);
				
		//	}
		//}
		Debug.Log (curveArray [0].height+ " firstHeight");
	}
	
	// Update is called once per frame
	void Update () {



	}
	
	
	void GetRelativeHeightsFromAnimationCurvePattern(AnimationCurve[] animationCurvePattern, Curve[] curveArray){
		//Debug.Log ("animationCurvePattern.Length=" + animationCurvePattern.Length);
		for (int a=0; a<animationCurvePattern.Length; a++) {
			curveArray [a].keyframeValues = new float[animationCurvePattern [a].length];
		}//長さ確定　インスタンス化
		
		for (int k=0; k<animationCurvePattern.Length; k++) {
			curveArray [k].height = 
				animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[animationCurvePattern [k].length- 1].time) 
					- animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[0].time);
			Debug.Log("curveArray["+k+"].height="+curveArray[k].height);
			for (int i=1; i<animationCurvePattern[k].length-1; i++) {
				/*Debug.Log("animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[i].time)_"+animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[i].time));
				Debug.Log("animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[0].time)_"+animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[0].time));*/
				curveArray [k].keyframeValues [i] = animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[i].time)
					- animationCurvePattern [k].Evaluate (animationCurvePattern [k].keys[0].time);
			}//相対高度へ変換
		}//配列curveの各要素の値確定
	}
	
	
	public void moveAnimation3 (Vector3 targetPosition ,int animationNumber){
		AnimationClip clip3 = new AnimationClip ();
		Debug.Log("X");
		AnimationCurve curveX =
			GetAdjustedAnimationCurve(targetPosition.x,gameObject.transform.position.x,animationCurvePattern,animationNumber,curveArray);
		
		Debug.Log("Y");
		AnimationCurve curveY =
			GetAdjustedAnimationCurve(targetPosition.y,gameObject.transform.position.y,animationCurvePattern,animationNumber,curveArray);
		
		Debug.Log ("Z");
		AnimationCurve curveZ = animationCurvePatternZoom [0];
		//GetAdjustedAnimationCurve (targetPosition.z - 2, gameObject.transform.position.z, animationCurvePatternZoom, 0, curveZoom);
		clip3.SetCurve ("", typeof(Transform), "localPosition.z", curveZ);
		
		Debug.Log("Curvechanged");
		
		clip3.SetCurve ("", typeof(Transform), "localPosition.x", curveX);
		clip3.SetCurve ("", typeof(Transform), "localPosition.y", curveY);
		animation.AddClip (clip3, "moveclip3");
		animation.Play ("moveclip3");
		
	}
	
	AnimationCurve GetAdjustedAnimationCurve(float targetPosition,float transformPosition,AnimationCurve[] animationCurvePattern ,int animationNumber ,Curve[] curveArray){
		
		AnimationCurve curve = new AnimationCurve ();
		curve.keys = animationCurvePattern[animationNumber].keys;
		
		float distanceToGo = targetPosition - transformPosition;
		float distanceToGoAdjusted = distanceToGo / curveArray [animationNumber].height; //元の幅と変更後の幅の比率
		
		Debug.Log ("distanceTOGo_" + distanceToGo);
		
		curve.MoveKey (0,new Keyframe (curve.keys[0].time, transformPosition));//配列0ばんめのキーフレーム変更
		curve.MoveKey (curve.length - 1, new Keyframe (curve.keys[curve.length - 1].time, targetPosition) );//終端キーフレーム変更
		
		for (int i=1; i<animationCurvePattern[animationNumber].length-1; i++) {
			curve.MoveKey (i, new Keyframe (curve.keys[i].time, (curve.Evaluate (curve.keys[0].time) + curveArray [animationNumber].keyframeValues [i] * distanceToGoAdjusted)  )  );
			Debug.Log("distanceToGoAdjusted_"+distanceToGoAdjusted);
			Debug.Log("curveArray_"+curveArray[animationNumber].keyframeValues[i]);
			Debug.Log(curve.keys[i].time + "time  " + "number "+i);
			Debug.Log(animationCurvePattern[animationNumber].Evaluate(animationCurvePattern[animationNumber].keys[i].time) +" firstkey"+i +" anime"+animationNumber);
			Debug.Log(curve.Evaluate (curve.keys[i].time) + " changedkey"+i);
			
		}//中間のキーフレーム置き換え
		
		Debug.Log (transformPosition+" c.P " +targetPosition+" t.P");
		Debug.Log(distanceToGoAdjusted + " changeheight");
		
		return curve;
	}

	public void	RightArrowButton(){	
		if(countObject < imageArrays.Length-1){
			countObject ++;
			moveAnimation3(imageArrays[countObject].transform.position,moveAnimationPatterns[countObject]);
			Debug.Log (1 +" cnt_"+countObject);
		}
		return;
	}
	
	public void	LeftArrowButton(){
		if(countObject > 0){
			countObject --;
			moveAnimation3(imageArrays[countObject].transform.position, moveAnimationPatterns[countObject]);
			Debug.Log (2+" cnt_"+countObject);
		}
		return;
	}

}