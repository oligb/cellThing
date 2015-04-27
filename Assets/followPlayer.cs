using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

	public Transform endCube;
	void Start () {
		endCube=GameObject.Find ("endCube 1").transform;
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos= new Vector3(endCube.position.x-15f,endCube.position.y,endCube.position.z);
		transform.position=pos;
	
	}
}
