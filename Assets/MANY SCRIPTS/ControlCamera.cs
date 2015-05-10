using UnityEngine;
using System.Collections;

public class ControlCamera : MonoBehaviour {

	// Use this for initialization
	public float inputScale=2f;
	public float mouseScale=1f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX=Input.GetAxis("Horizontal");
		float inputZ=Input.GetAxis("Vertical");
		float inputY=Input.GetAxis("Mouse ScrollWheel");
		float h = mouseScale * Input.GetAxis("Mouse X");
		float v = mouseScale * Input.GetAxis("Mouse Y");
		transform.Rotate(-v,h,0f);

			transform.Translate(new Vector3(inputX, inputY,inputZ)*inputScale);
	}
}
