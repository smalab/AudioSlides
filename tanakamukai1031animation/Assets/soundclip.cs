using UnityEngine;
using System.Collections;

public class soundclip : MonoBehaviour {
	
	private AudioSource sound01;
	//public bool a;
	//public bool b;
	public int c;
	public int d;
	
	void Start () {

		//AudioSourceコンポーネントを取得し、変数に格納
		sound01 = GetComponent<AudioSource>();
		//sound01.PlayOneShot(sound01.clip);
		//a = GetComponent<myscript>().situation1;
		//b = GetComponent<myscript>().situation3;
		//c = GetComponent<myscript>().flag;
	}
	
	void Update () {
		c = GetComponent<myscript>().flag;
		d = GetComponent<myscript>().flag1;
		//指定のキーが押されたら音声ファイル再生
		if(c == 1 && d ==0) 
			sound01.PlayOneShot(sound01.clip);

	
		if( d == 1 ){
			sound01.audio.Stop();
		}
			//sound01.audio.play(sound01.clip);
		}
}