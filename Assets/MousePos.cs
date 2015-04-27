using UnityEngine;
using System.Collections;

public class MousePos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX=Input.GetAxis("Horizontal");
		float mouseY=Input.GetAxis("Vertical");

		transform.Translate(mouseX,mouseY,0f);

	}
}
