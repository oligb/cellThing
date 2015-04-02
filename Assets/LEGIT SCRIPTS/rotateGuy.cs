using UnityEngine;
using System.Collections;

public class rotateGuy : MonoBehaviour {

	// Use this for initialization
	public Vector3 rotationVec= new Vector3(1f,1f,1f);
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotationVec);
	}
}
