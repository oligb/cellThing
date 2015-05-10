using UnityEngine;
using System.Collections;

public class CubeRepulsion : MonoBehaviour {

	public GameObject otherCube;
	public float moveSpeed=1f;

	public Vector3 startPos;
	public float repulseScale=5f;
	public Vector3 targetPos;
	public float distToCenter;
	public float perlinLoc=0;
	public float perlinInc=.1f;
	public float perlinMod;
	public float perlinScale=.5f;
	public GameObject childCube;

	public bool repulse=true;

	//public float 

	void Start () {
		perlinScale=Random.Range(.1f,.5f);
		perlinLoc+=Random.Range(0f,500f);
		startPos=transform.position;
		otherCube=GameObject.Find("OtherCube");
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


		if(repulse){
		if(childCube != null){
		childCube.transform.LookAt(otherCube.transform.position);
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

		if(childCube != null){
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
