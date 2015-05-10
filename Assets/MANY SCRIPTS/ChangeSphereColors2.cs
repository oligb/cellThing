using UnityEngine;
using System.Collections;

public class ChangeSphereColors2 : MonoBehaviour {
	//public float ThisIsAVeryLongVariableNameASDFDKALKDQOWKEOAPCKASPCLASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPAPDLWOKQOEJQOEQWEPQDPALSEPLQEP=2f;
	// Use this for initialization
	//public Color col;
	
	public float sphereHue=.2f;
	public float traileHue=.2f;
	public float traileHue2=.2f;
	public GameObject manager;
	void Start () {
		manager=GameObject.Find("manager");
		Colors();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		sphereHue=manager.GetComponent<ColorManager2>().sphereHue;
		traileHue=manager.GetComponent<ColorManager2>().traileHue;
		traileHue2=manager.GetComponent<ColorManager2>().traileHue2;
		if(Input.GetKeyDown("space")){
			Colors();
			//Colors2();
		}
		
	}
	
	void Colors(){
		
		//Color col2= GetComponent<MeshRenderer>().materials[0].color;
		//col2.g=Random.Range(0f,.7f);
		Color col= HSVRGB.HSVToRGB(sphereHue,Random.Range(.3f,.8f),1f);
		GetComponent<MeshRenderer>().materials[0].color=col;
		
		
		//Color col= GetComponent<TrailRenderer>().materials[0].color;
		//col.g=Random.Range(0f,.8f);
		
		Color col2= HSVRGB.HSVToRGB(traileHue,Random.Range(.3f,.8f),1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color2",col2);
		
		Color col3= HSVRGB.HSVToRGB(traileHue2,Random.Range(.3f,.8f),1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color1",col3);
		
		Camera.main.backgroundColor=col3;
	}
	void Colors2(){
		
		//Color col2= GetComponent<MeshRenderer>().materials[0].color;
		//col2.g=Random.Range(0f,.7f);
		Color col= HSVRGB.HSVToRGB(sphereHue,.7f,1f);
		GetComponent<MeshRenderer>().materials[0].color=col;
		
		
		//Color col= GetComponent<TrailRenderer>().materials[0].color;
		//col.g=Random.Range(0f,.8f);
		
		Color col2= HSVRGB.HSVToRGB(traileHue,.7f,1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color2",col2);
		
		Color col3= HSVRGB.HSVToRGB(traileHue2,.7f,1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color1",col3);
		
		Camera.main.backgroundColor=col;
	}
}
