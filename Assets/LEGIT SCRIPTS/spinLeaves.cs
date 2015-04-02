using UnityEngine;
using System.Collections;

public class spinLeaves : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.RotateAround(transform.position,transform.position,Time.time);
		//	(new Vector3(0f,5f,0f));
		//transform.Rotate(0, Time.deltaTime, 0, Space.Self);

		transform.localRotation = Quaternion.Euler(0f,Time.time,0f);

	}
}
