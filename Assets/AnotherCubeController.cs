using UnityEngine;
using System.Collections;

public class AnotherCubeController : MonoBehaviour {


	public float resetSpeed=1f;
	// Use this for initialization
	public float coroutineShutoff=1f;
	void Start () {
		//InvokeRepeating("Zero",0f,resetSpeed);
		
	}
	
	
	// Update is called once per frame
	void Update () {

	

		if(Input.GetKeyDown("space")){
			//transform.localPosition=Vector3.zero;
			Zero ();
		}
		
		
		//transform.Rotate(10f,10f,10f);
	}

	void Zero(){
		transform.localPosition=Vector3.zero;
	}
	
	public void CallCoroutine(Vector3 pos,float speed){
		StartCoroutine(MoveOutCube(pos,speed));
	}
	public IEnumerator MoveOutCube(Vector3 targetPos,float moveOutSpeed){
		//while (Vector3.Distance(transform.position,targetPos)>=coroutineShutoff){
		while (true){

			transform.LookAt(targetPos);
			transform.Translate(Vector3.forward*moveOutSpeed);

			
			yield return 0;
		}
		Debug.Log("exitedWhile");
	}
}
