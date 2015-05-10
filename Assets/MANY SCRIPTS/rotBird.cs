using UnityEngine;
using System.Collections;

public class rotBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(1f,5f,5f));
	}
}