using UnityEngine;
using System.Collections;

public class CoroutineCenter : MonoBehaviour {

	// Use this for initialization
	public float spinTime=1f;
	public float addedRotation=5f;
	public int numExtra=0;
	public int maxExtra=3;
	public float xRot;
	public float yRot;
	public float zRot;

	void Start () {
		float randoInit=Random.Range (0f,1f);
		StartCoroutine(RotateStuff(spinTime,randoInit,false));
		//StartCoroutine(XRot());

	}

	IEnumerator XRot(){
		float maxRot=Random.Range(10f,50f);
		float rotIncrement=.5f;
		while(xRot<maxRot){
			xRot+=rotIncrement;
			yield return 0;
		}



	}
	IEnumerator RotateStuff(float time, float rando,bool extra){
		if(extra){
			numExtra++;
		}
		float i= 0f;
		float rate= 1f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;

				if(rando<=.33f){
					transform.Rotate (addedRotation,0f,0f);
				}
				else if(rando<=.66f &&rando>.33f){
					transform.Rotate (0f,addedRotation,0f);
				}
				else if(rando>66f){
					transform.Rotate (0f,0f,addedRotation);
				}
			/*
			float rando2=Random.Range(0f,1f);
			if(rando2<=.01f){
				Debug.Log("yep");
				if(numExtra<maxExtra){
				StartCoroutine(RotateStuff(Random.Range(0f,10f),Random.Range(0f,1f),true));
				}
				else{
					StartCoroutine(RotateStuff(Random.Range(0f,10f),Random.Range(0f,1f),false));
				}
				}
*/
				yield return 0;
	}
		StartCoroutine(RotateStuff(spinTime,Random.Range(0f,1f),false));
	//numExtra-=1;
		}
	// Update is called once per frame
	void Update () {

	
	//	transform.Rotate(xRot,yRot,zRot);
	
	}
}
