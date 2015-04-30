using UnityEngine;
using System.Collections;

public class rotateCamera : MonoBehaviour {

	// Use this for initialization
	public float mouseScale=1f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX= mouseScale * Input.GetAxis ("Mouse X");
		float mouseY= mouseScale * Input.GetAxis ("Mouse Y");
		transform.Rotate(-mouseY,mouseX,0f);

		if(Input.GetKeyDown("space")){
			//Application.LoadLevel("Spheres");
		}
	}
}
