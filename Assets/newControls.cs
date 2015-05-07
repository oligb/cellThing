using UnityEngine;
using System.Collections;

public class newControls : MonoBehaviour {

	// Use this for initialization
	public Vector3 speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed);
	}
}
