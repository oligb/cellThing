using UnityEngine;
using System.Collections;

public class SuperSecretCubeController : MonoBehaviour {

	// Use this for initialization
	public Transform centerObject;
	public Vector3 velocity;
	public Vector3 previous;

	void Start () {
		centerObject=GameObject.Find("Center").transform;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(centerObject.position);
		//transform.Rotate(Vector3.forward);
		/*
		velocity = (transform.position - previous) / Time.deltaTime;
		previous = transform.position;

		Vector3 scale= velocity;
		scale.x=Mathf.Clamp(scale.x,1f,2f);
		scale.y=Mathf.Clamp(scale.y,1f,2f);
		scale.z=Mathf.Clamp(scale.z,1f,2f);

		transform.localScale= scale;
		*/

	}
	void FixedUpdate () {


	}
}




