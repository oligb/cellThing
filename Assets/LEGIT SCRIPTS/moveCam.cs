using UnityEngine;
using System.Collections;

public class moveCam : MonoBehaviour {

	public float mouseX;
	public float mouseY;
	public float yScale=2f;
	public float xScale=2f;
	public GameObject cam;
	public Vector3 mousePos;
	public Vector3 pos_;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		mouseY=Input.GetAxis("Mouse Y");

		transform.Translate(Vector3.forward*mouseY);
		/*
		mouseX=Input.GetAxis("Mouse X")*xScale;
		mouseY=Input.GetAxis("Mouse Y");
		pos_ = transform.position;
		pos_+= (new Vector3(0f,0f,mouseY));

		if(pos_.x>1f && pos_.x<6f){

		}
		else{
			transform.Translate(new Vector3(0f,0f,mouseY));
		}

		cam.transform.Rotate(new Vector3(0f,mouseX,0f));
	*/
	}
}
