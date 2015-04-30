using UnityEngine;
using System.Collections;

public class rotateCenter : MonoBehaviour {

	// Use this for initialization
	public float speed=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		transform.Rotate(new Vector3(speed,speed,speed));
	}
}
