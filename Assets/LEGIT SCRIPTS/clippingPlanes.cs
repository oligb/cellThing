using UnityEngine;
using System.Collections;

public class clippingPlanes : MonoBehaviour {

	// Use this for initializatio
	public float appearSpeed=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Camera>().farClipPlane-=appearSpeed;
		GetComponent<Camera>().nearClipPlane-=appearSpeed;

	}
}
