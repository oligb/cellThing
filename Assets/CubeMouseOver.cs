using UnityEngine;
using System.Collections;

public class CubeMouseOver : MonoBehaviour {

	// Use this for initialization
	public bool grow=false;
	public float growSpeed=.1f;
	public float totalGrowth=0f;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnMouseOver(){

		transform.localScale+=new Vector3(growSpeed,growSpeed,growSpeed);
		totalGrowth+=growSpeed;

	}

	void OnMouseExit(){
	//	gameObject.ScaleBy(new Vector3(-totalGrowth,-totalGrowth,-totalGrowth),2f,.5f,EaseType.easeInBounce);
		//totalGrowth=0f;
	}

}
