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

		rotationVector.x=Mathf.Clamp(rotationVector.x,-10f,10f);
		rotationVector.z=Mathf.Clamp(rotationVector.z,-10f,10f);



		/*

			//rotationVector.z+=mouseY;
			rotationVector.x=16f+mouseY*3f;
		rotationVector.y=-16f+mouseX*3f;
		rotationVector.z=-16f+mouseX*3f;
		
		rotationVector.x=Mathf.Clamp(rotationVector.x,-18f,-12f);
		rotationVector.y=Mathf.Clamp(rotationVector.y,-18f,-12f);
		rotationVector.z=Mathf.Clamp(rotationVector.z,-18f,-12f);

		*/
		if(Input.GetKeyDown("space")){

			rotationVector= new Vector3(-20f,-20f,-20f);
		}
		
	}
}
