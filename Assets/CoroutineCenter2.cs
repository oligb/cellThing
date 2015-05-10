using UnityEngine;
using System.Collections;

public class CoroutineCenter2 : MonoBehaviour {
	
	// Use this for initialization
	public float spinTime=1f;
	public float addedRotation=5f;
	public int numExtra=0;
	public int maxExtra=3;
	public float xRot;
	public float yRot;
	public float zRot;
	public float startSpinTime;
	public Sawtooth midi;

	
	void Start () {
		midi=GameObject.Find ("manager").GetComponent<Sawtooth>();
		startSpinTime=spinTime;
		float randoInit=Random.Range (0f,1f);
		StartCoroutine(RotateStuff(randoInit));

		//StartCoroutine(XRot());
		
	}
	/*
	IEnumerator XRot(){
		float maxRot=Random.Range(10f,50f);
		float rotIncrement=.5f;
		while(xRot<maxRot){
			xRot+=rotIncrement;
			yield return 0;
		}
		*/
		
		
	IEnumerator RotateStuff(float rando){
		int i=0;
		while (true) {

			if(i>=spinTime){
				spinTime = startSpinTime*Random.Range(0f,3f);
				rando=Random.Range(0f,1f);
				i=0;
			}
			/*
			if(rando<=.33f){
				midi.waveType=0;
				//transform.Rotate (addedRotation,0f,0f);
			}
			else if(rando<=.66f &&rando>.33f){
				midi.waveType=1;
				//transform.Rotate (0f,addedRotation,0f);
			}
			else if(rando>.66f){
				midi.waveType=2;
				//transform.Rotate (0f,0f,addedRotation);
			}
*/
			transform.Rotate (0f,0f,addedRotation);

			/*
			if(rando<=.5f){
				transform.Rotate (0f,addedRotation,0f);
			}
			else{
				transform.Rotate (0f,addedRotation,0f);
			}
			*/


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



			i++;
			yield return 0;
		}
		//StartCoroutine(RotateStuff(spinTime,Random.Range(0f,1f),false));
		//numExtra-=1;
	}
	// Update is called once per frame
	void Update () {
		
		
		//	transform.Rotate(xRot,yRot,zRot);
		
	}
}
