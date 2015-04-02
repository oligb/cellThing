using UnityEngine;
using System.Collections;

public class rotateCam : MonoBehaviour {
	public float rotSpeed=5f;
	Camera cam;
	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
	
	}
	
	// Update is called once per frame
	void Update () {
		//cam.fieldOfView;
		transform.Rotate(new Vector3(0f,0f,rotSpeed));
	}
}
