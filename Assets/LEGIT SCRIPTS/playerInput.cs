using UnityEngine;
using System.Collections;

public class playerInput : MonoBehaviour {

	// Use this for initialization
	public float speed = 5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 input=new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0f);

		transform.Translate(input*speed);


	}
}
