using UnityEngine;
using System.Collections;

public class soundclip : MonoBehaviour {
	
	public AudioSource sound01;
	public AudioClip otherClip;
	//public bool a;
	//public bool b;
	public int c;
	public int d;
	public int e = 0;
	
	void Start () {

		//AudioSourceコンポーネントを取得し、変数に格納
		sound01 = GetComponent<AudioSource>();
		//c = GetComponent<myscript>().flag;
		//d = GetComponent<myscript>().flag1;
		/*if (c == 1 && d == 0 ) {
						sound01.PlayOneShot (sound01.clip);
				}*/
		//sound01.PlayOneShot(sound01.clip);
		//a = GetComponent<myscript>().situation1;
		//b = GetComponent<myscript>().situation3;
		//c = GetComponent<myscript>().flag;
	}
	
	void Update () {
		c = GetComponent<myscript>().flag;
		d = GetComponent<myscript>().flag1;
		//指定のキーが押されたら音声ファイル再生
		if (c == 1 && d == 0 && e == 0) {
			sound01.PlayOneShot (sound01.clip);
			e++;
			//sound01.Play( );
			//sound01.clip = otherClip;
				}
		//Debug.Log (sound01.isPlaying);
		//if (!sound01.isPlaying){
			//sound01.clip = otherClip;
			//sound01.Play();
				}
		//Debug.Log (sound01.isPlaying);
		//if( d == 1 )
			//sound01.audio.Stop();

			//sound01.audio.play(sound01.clip);
		}