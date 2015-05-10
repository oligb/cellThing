using UnityEngine;
using System.Collections;

public class changeColors : MonoBehaviour {
	//public float ThisIsAVeryLongVariableNameASDFDKALKDQOWKEOAPCKASPCLASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPAPDLWOKQOEJQOEQWEPQDPALSEPLQEP=2f;
	// Use this for initialization
//public Color col;
	void Start () {

		Colors();


	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("space")){

			Colors();
		}

	}

	void Colors(){
		
		Color col= GetComponent<TrailRenderer>().materials[0].color;
		col.g=Random.Range(0f,.8f);
		GetComponent<TrailRenderer>().materials[0].color=col;
		
		Color col2= GetComponent<MeshRenderer>().materials[0].color;
		col2.g=Random.Range(0f,.7f);
		GetComponent<MeshRenderer>().materials[0].color=col2;
	}
}
