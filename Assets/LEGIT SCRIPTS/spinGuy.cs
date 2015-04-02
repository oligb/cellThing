using UnityEngine;
using System.Collections;

public class spinGuy : MonoBehaviour {

	public float speed=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(1f,1f,1f)*speed);
	}
}
