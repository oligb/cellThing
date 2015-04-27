using UnityEngine;
using System.Collections;

public class spinCubes : MonoBehaviour {

	// Use this for initialization
	public float rotSpeed=5f;

	void Start () {
		rotSpeed=Random.Range (-5f,5f);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(0f,0f,rotSpeed);
	}
}
