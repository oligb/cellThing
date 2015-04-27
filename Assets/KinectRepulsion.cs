using UnityEngine;
using System.Collections;

public class KinectRepulsion : MonoBehaviour {
	
	public Transform centerCube,leftHand,rightHand,otherCube;

	public float distLeft,distRight,distCenter;

	public float moveSpeed=1f;
	
	public Vector3 startPos;
	public float repulseScale=5f;
	public Vector3 targetPos;
	public float distToCenter;
	public float perlinLoc=0;
	public float perlinInc=.1f;
	public float perlinMod;
	public float perlinScale=.5f;
	public Transform childCube;
	
	public bool repulse=true;
	
	//public float 
	
	void Start () {
		perlinScale=Random.Range(.1f,.5f);
		perlinLoc+=Random.Range(0f,500f);
		startPos=transform.position;
		//childCube=transform.GetChild(0).transform;
		leftHand=GameObject.Find("LEFTHAND").transform;
		rightHand=GameObject.Find("RIGHTHAND").transform;
		centerCube=GameObject.Find("HEAD").transform;

		StartCoroutine("RepulseCube");
		
	}
	public IEnumerator RepulseCube(){
		while(true){
			//	transform.LookAt(targetPos);
			Vector3 moveDir=targetPos-transform.position;
			transform.Translate(moveDir*moveSpeed);
			yield return 0;
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		distRight=Vector3.Distance(startPos,rightHand.position);
		distLeft=Vector3.Distance(startPos,leftHand.position);
		distCenter=Vector3.Distance(startPos,centerCube.position);

		/*
		if(distCenter<distRight &&distCenter<distLeft){
			otherCube=centerCube;
		}
		else if(distLeft<distRight){
			otherCube=leftHand;
		}
		else{
			otherCube=rightHand;
		}
*/

		if(distLeft<distCenter){
			otherCube=leftHand;
		}
		else if(distRight<distCenter){
			otherCube=rightHand;
		}
		else{
			otherCube=centerCube;
		}

		if(repulse){
			if(childCube != null && transform.position!=startPos){
				childCube.LookAt(otherCube.transform.position);
			}
			
			perlinLoc+=perlinInc;
			perlinMod = .5f-Mathf.PerlinNoise(0f,perlinLoc)*perlinScale;
			
			distToCenter= Vector3.Distance( otherCube.transform.position,startPos);
			if(distToCenter<=repulseScale){
				Vector3 otherToCenter= otherCube.transform.position-startPos;
				Vector3 otherToCenterNorm= otherToCenter.normalized;
				
				targetPos =startPos+otherToCenterNorm*-1*(repulseScale-distToCenter);
				targetPos.y+=perlinMod;
				
				//targetPos=startPos+otherToCenter;
				//targetPos.y=Mathf.Abs(otherToCenter.y);
				
				
			}
			else{
				targetPos=startPos;
				targetPos.y+=perlinMod;
			}
			//transform.position=targetPos;
			
		}
		
		else{
			
			if(childCube != null && transform.position!=startPos){
				childCube.transform.LookAt(otherCube.transform.position);
			}
			
			perlinLoc+=perlinInc;
			perlinMod = .5f-Mathf.PerlinNoise(0f,perlinLoc)*perlinScale;
			
			distToCenter= Vector3.Distance( otherCube.transform.position,startPos);
			if(distToCenter<=repulseScale){
				
				targetPos=otherCube.transform.position;
			}
			else{
				
				targetPos=startPos;
				targetPos.y+=perlinMod;
				//transform.position=targetPos;
				
				
			}
			
		}
	}
}
