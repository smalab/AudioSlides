using UnityEngine;
using System.Collections;

public class clickMove : MonoBehaviour
{
	public Transform target;
	
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 vec = Input.mousePosition;
			vec.z = 10f;
			
			target.position = camera.ScreenToWorldPoint(vec);
		}
	}
}
