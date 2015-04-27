using UnityEngine;
using System.Collections;

public class moveGuy : MonoBehaviour {

	// Use this for initialization
	public float speed=5f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward*speed);
	}
}
