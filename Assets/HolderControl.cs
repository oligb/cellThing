using UnityEngine;
using System.Collections;

public class HolderControl : MonoBehaviour {

	// Use this for initialization
	public Vector3 rotationVector;
	public float cubeMoveSpeed=5f;
	public float mouseScale=1f;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX= mouseScale * Input.GetAxis ("Mouse X");
		float mouseY= mouseScale * Input.GetAxis ("Mouse Y");
		rotationVector.z+=mouseY;
		rotationVector.x+=mouseX;

		if(Input.GetKeyDown("space")){

			rotationVector= new Vector3(-20f,-20f,-20f);
		}
		
	}
}
