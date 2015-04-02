using UnityEngine;
using System.Collections;

public class CamMove2 : MonoBehaviour {
	
	public float speed=5f;
	public float inputScale=1f;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.forward*speed);
		float inputX= Input.GetAxis("Horizontal")*inputScale;
		float inputY= Input.GetAxis("Vertical")*inputScale;
		transform.Rotate(new Vector3( -inputY,  inputX,0f));

		Vector3 tRot=transform.rotation.eulerAngles;
		tRot.z=0f;
		transform.rotation= Quaternion.Euler ( tRot);

	}
}
