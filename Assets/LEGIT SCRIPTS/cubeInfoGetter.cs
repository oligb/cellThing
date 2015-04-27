using UnityEngine;
using System.Collections;

public class cubeInfoGetter : MonoBehaviour {

	// Use this for initialization
	public GameObject manager;
	public bool grow=false;
	public float growSpeed=.1f;
	public float totalGrowth=0f;

	void Start () {
		manager=GameObject.Find("logic");

	
	}
	
	// Update is called once per frame
	void Update () {

		float perlinScaler=manager.GetComponent<jiggleCube>().perlinScaler;
		float scaler=manager.GetComponent<jiggleCube>().scaler;
		float perlinLoc=manager.GetComponent<jiggleCube>().perlinLoc;

		float perlin= Mathf.PerlinNoise(transform.position.x/perlinScaler+perlinLoc,transform.position.z/perlinScaler+perlinLoc)*scaler;
		transform.localScale = new Vector3(perlin,perlin,perlin)+new Vector3(totalGrowth,totalGrowth,totalGrowth);
	}


		/*
		if(grow){
			totalGrowth+=growSpeed;
		}
	}

	void OnMouseOver(){
		
	//	transform.localScale+=new Vector3(growSpeed,growSpeed,growSpeed);
		//totalGrowth+=growSpeed;
		grow=true;
	}
	
	void OnMouseExit(){
		grow=false;
		float duration=2f;
		Invoke("ResetGrowth",duration);
			gameObject.ScaleAdd(new Vector3(-totalGrowth,-totalGrowth,-totalGrowth),duration,.2f,EaseType.easeOutBounce);
	//	totalGrowth=0f;
	}
	void ResetGrowth(){
		totalGrowth=0f;
	}
*/
}
