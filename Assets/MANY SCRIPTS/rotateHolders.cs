using UnityEngine;
using System.Collections;

public class rotateHolders : MonoBehaviour {

	// Use this for initialization
	public Vector3 rotVector;
	public GameObject controller;
	public bool flip=false;
	void Start () {
		
		controller=GameObject.Find("HolderController");
		if(Random.Range(0f,1f)>.5f){
			flip=true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		rotVector=controller.GetComponent<HolderControl>().rotationVector;

		
		transform.Rotate(rotVector);
		/*
		if(flip){
		transform.Rotate(rotVector);
		}
		else{
		transform.Rotate(-rotVector);
		}
*/
	}
}
