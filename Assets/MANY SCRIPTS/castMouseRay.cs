using UnityEngine;
using System.Collections;

public class CastMouseRay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
		Camera cam=gameObject.GetComponent<Camera>();
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		

	}
}
