using UnityEngine;
using System.Collections;

public class cameraRot : MonoBehaviour {

	// Use this for initialization
	public float rotSpeed=5f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX=Input.GetAxis("Mouse X");

		transform.Rotate(0f,inputX,0f);

	}
}
