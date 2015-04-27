﻿using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {


		transform.Rotate(10f,10f,10f);
	}
	
	public void CallCoroutine(Vector3 pos,float speed){
		StartCoroutine(MoveOutCube(pos,speed));
	}
	public IEnumerator MoveOutCube(Vector3 targetPos,float moveOutSpeed){
		//while (Vector3.Distance(transform.position,targetPos)>=2f){
		while (true){
			if(Input.GetKeyDown("space")){

				targetPos= transform.position;

			//	transform.position=GameObject.Find("Main Camera").transform.position+Vector3.forward*10f;
			}
			transform.LookAt(targetPos);
			transform.Translate(Vector3.forward*moveOutSpeed);

			yield return 0;
		}
	}
}