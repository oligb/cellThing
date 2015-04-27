using UnityEngine;
using System.Collections;

public class AnotherRotateCam : MonoBehaviour {
	public float rotSpeed=5f;
	Camera cam;
	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
		
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX=Input.GetAxis("Horizontal")*rotSpeed;
		float mouseY=Input.GetAxis("Vertical")*rotSpeed;
		
		transform.Rotate(0f,-mouseX,-mouseY);
	}
}
