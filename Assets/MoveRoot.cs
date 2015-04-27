using UnityEngine;
using System.Collections;

public class MoveRoot : MonoBehaviour {

	// Use this for initialization
	public float speed=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float inputX=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
		float inputY=Input.GetAxis("Vertical")*Time.deltaTime*speed;
		GetComponent<Rigidbody>().AddForce (inputY,0f,-inputX);
	}
}
