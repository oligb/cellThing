using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tweenTest : MonoBehaviour {

	// Use this for initialization
	public int currentPos;
	public GameObject birdManager;
	public List<Vector3> positions;

	public bool onPerch;
	public bool moving=false;
	public float likelihoodToMovePerFrame=1f;
	public int target;
	void Start () {
		birdManager=GameObject.Find("BirdManager");
		positions=birdManager.GetComponent<BirdManager>().birdPerches;
		//gameObject.MoveBy(new Vector3(1f,1f,1f),2f,0f, EaseType.easeInExpo, LoopType.pingPong);
	
	}
	
	// Update is called once per frame
	void Update () {

		float chanceRando=Random.Range(0f,100f);
		if (chanceRando<=likelihoodToMovePerFrame && !moving){

			target=Random.Range (0,positions.Count);
			MoveBirdDirectly(target);

		//	StartCoroutine(MoveBirdDirectly(target));
		}
		/*
		if(Vector3.Distance(transform.position,positions[currentPos])<=.1f){
			moving=false;
		}
		*/
		if(transform.position==positions[target]){
			moving=false;
			currentPos=target;
			/*
			Vector3 rot= transform.rotation.eulerAngles;
			rot.x=0f;
			transform.rotation =Quaternion.Euler(rot);
			*/
		}

		if(moving){
			transform.LookAt(positions[target]);
		}

	}
	/*
	public int MoveBirdUpDown(){
	}

	public int MoveBirdOutIn(){

	}
	*/

	//IEnumerator MoveBirdDirectly(int target){




	//}
			               
	public int MoveBirdDirectly(int target){


		moving=true;
		gameObject.MoveTo(positions[target],2f,0f);

		return target;
	}
	
}
