using UnityEngine;
using System.Collections;

public class select : MonoBehaviour {

	public AnimationCurve[] animationCurvePattern;//予め設定する値（アニメーションのパターン）0-4で指定
	public  GameObject[] imageArrays = new GameObject[4];//移動先オブジェクト
	public int[] moveAnimationPatterns = new int[4] ;//アニメーションのパターンの順番
	int countObject=0;//現在のオブジェクトの位置
	
	struct Curve{
		public float height;//基準の高さ
		public float[] keyframeValues;//相対高度
	}

	Curve[] curveArray = new Curve[1];//moveの長さ確定
	

	void Start () {
		GameObject.Find ("GUI Text").guiText.text = "moveAnimation3 sample";

		GetRelativeHeightsFromAnimationCurvePattern ();

	}
	
	void GetRelativeHeightsFromAnimationCurvePattern(){
				for (int a=0; a<animationCurvePattern.Length; a++) {
						curveArray [a].keyframeValues = new float[animationCurvePattern [a].length];
				}//長さ確定
		
				for (int k=0; k<animationCurvePattern.Length; k++) {
						curveArray [k].height = 
				animationCurvePattern [k].Evaluate (animationCurvePattern [k].length - 1) - animationCurvePattern [k].Evaluate (0);//各々のmoveのM0決定
						for (int i=1; i<animationCurvePattern[k].length-1; i++) {
								curveArray [k].keyframeValues [i] = animationCurvePattern [k].Evaluate (i) - animationCurvePattern [k].Evaluate (0);
						}//相対高度へ変換
				}//配列curveの各要素の値確定
		}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){	
			if(countObject < imageArrays.Length-1){
				countObject += 1;
				Debug.Log (1);
				moveAnimation3(imageArrays[countObject].transform.position,moveAnimationPatterns[countObject]);
			}
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			if(countObject > 0){
				countObject -=1;
				moveAnimation3(imageArrays[countObject].transform.position,moveAnimationPatterns[countObject]);
				Debug.Log (2);
			}
		}

	
	}

	void moveAnimation3 (Vector3 targetPosition ,int animationNumber){

		AnimationCurve curveX =
			GetAdjustedAnimationCurve(targetPosition.x,gameObject.gameObject.transform.position.x,animationNumber);

		AnimationCurve curveY =
			GetAdjustedAnimationCurve(targetPosition.y,gameObject.gameObject.transform.position.y,animationNumber);

		AnimationCurve curveZ =
			GetAdjustedAnimationCurve(targetPosition.z-2,gameObject.gameObject.transform.position.z,animationNumber);

		AnimationClip clip2 = new AnimationClip ();
		clip2.SetCurve ("", typeof(Transform), "localPosition.x", curveX);
		//clip2.SetCurve ("", typeof(Transform), "localPosition.y", curveY);
		//clip2.SetCurve ("", typeof(Transform), "localPosition.z", curveZ);
		animation.AddClip (clip2, "moveclip2");
		animation.Play ("moveclip2");
		
	}

	AnimationCurve GetAdjustedAnimationCurve(float targetPosition,float transformPosition,int animationNumber){

		AnimationCurve curve = new AnimationCurve ();
		curve.keys = animationCurvePattern [animationNumber].keys;
		float distanceToGoAdjusted, distanceToGo;
		distanceToGo = targetPosition - transformPosition;
		distanceToGoAdjusted = distanceToGo / curveArray [animationNumber].height; //元の幅と変更後の幅の比率
		Keyframe currentPositionKey = new Keyframe (0, transformPosition);//配列0ばんめのキーフレーム変更
		Keyframe targetPositionKey = new Keyframe (animationCurvePattern [animationNumber].length - 1, targetPosition);//終端キーフレーム変更

		curve.MoveKey (0, currentPositionKey);
		curve.MoveKey (curve.length - 1, targetPositionKey);//両端キーフレーム置き換え

		/*for (int i=1; i<animationCurvePattern[animationNumber].length-1; i++) {
				curve.MoveKey (i, new Keyframe (i, curve.Evaluate (0) + curveArray [animationNumber].keyframeValues [i] * distanceToGoAdjusted));
		}//中間のキーフレーム置き換え*/

		return curve;

	}





}
