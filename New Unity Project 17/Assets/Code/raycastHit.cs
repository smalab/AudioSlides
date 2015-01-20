using UnityEngine;
using System.Collections;

public class  raycastHit : MonoBehaviour {
	
	private Ray ray;
	private RaycastHit  hit;
	private GameObject  selectedObject;
	
	void Update () {
		
		ray = Camera. main.ScreenPointToRay (Input.mousePosition);
		
		if (Physics.Raycast (ray, out hit, 1000)) {
					Debug.Log (ray);
					hit.transform.gameObject.renderer.material.color = Color.red;
					selectedObject = hit.transform.gameObject;
			} else {
				////	Debug.Log (ray+"out");
		}
	}
}