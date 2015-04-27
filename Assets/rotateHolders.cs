using UnityEngine;
using System.Collections;

public class rotateHolders : MonoBehaviour {

	// Use this for initialization
	public Vector3 rotVector;
	public GameObject controller;
	void Start () {
		
		controller=GameObject.Find("HolderController");
	}
	
	// Update is called once per frame
	void Update () {
		rotVector=controller.GetComponent<HolderControl>().rotationVector;
		
		transform.Rotate(rotVector);
	
	}
}
