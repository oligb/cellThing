using UnityEngine;
using System.Collections;

public class FakeGravity : MonoBehaviour {

	// Use this for initialization
	public float gravityAmt=5f;
	public bool grav=true;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnGravity(){
		grav=true;
	}
	public void OffGravity(){
		grav=false;
	}

	void FixedUpdate(){
		if(grav){
		GetComponent<Rigidbody>().AddForce(Vector3.down*gravityAmt);
		}
		else{
		}
	}
}
