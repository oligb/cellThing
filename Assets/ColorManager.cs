using UnityEngine;
using System.Collections;

public class ColorManager : MonoBehaviour {

	// Use this for initialization
	
	public float sphereHue=.2f;
	public float traileHue=.2f;
	public float traileHue2=.2f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			sphereHue=Random.Range(0f,1f);
			traileHue=Random.Range(0f,1f);
			traileHue2=Random.Range(0f,1f);
		}

	}
}
