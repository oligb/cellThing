using UnityEngine;
using System.Collections;

public class SnapMove : MonoBehaviour {

	// Use this for initialization
	public float moveScale=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY= Input.GetAxis("Vertical");
		Vector3 posVector= new Vector4(inputX,inputY,0f)*moveScale;
		transform.position=posVector;
	
	}
}
