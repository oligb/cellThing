using UnityEngine;
using System.Collections;

public class ColorBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Color col2= GetComponent<SkinnedMeshRenderer>().materials[0].color;
		col2.g-=Random.Range(0f,.7f);
		GetComponent<SkinnedMeshRenderer>().materials[0].color=col2;
		//gameObject
	}
	
	// Update is called once per frame
	void Update () {

	}
}
