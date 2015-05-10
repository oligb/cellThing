using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SquareController : MonoBehaviour {

	// Use this for initialization
	public List<GameObject> squareList;
	public Vector3 mousePos;
	public GameObject circle1;
	public GameObject circle2;
	public GameObject circle3;
	public GameObject circle4;
	public Camera cam;
	public Color cubeWhite;
	public Color cubeBlack;
	public Color myColor;
	public Color oppositeColor;
	public bool white=true;
	public bool mouseCube=false;
	public Vector3 currentMouseCubePos;




			
	void Start () {
		squareList=GameObject.Find("CreateSquares").GetComponent<SpawnSquares>().squares;
		cam=GameObject.Find("Main Camera").GetComponent<Camera>();
		if(white){
			gameObject.GetComponent<MeshRenderer>().materials[0].color=cubeWhite;
			myColor=cubeWhite;
			oppositeColor=cubeBlack;
		}
		else{
			gameObject.GetComponent<MeshRenderer>().materials[0].color=cubeBlack;
			myColor=cubeBlack;
			oppositeColor=cubeWhite;
		}
	}

	void OnMouseOver(){
		mouseCube=true;
	}
	void OnMouseExit(){
		mouseCube=false;
	}
	// Update is called once per frame
	void Update () {
	//mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
		//mouseCube=false;

		foreach(GameObject squareT in squareList){
			if(squareT.GetComponent<SquareController>().mouseCube==true){
				currentMouseCubePos=squareT.transform.position;
			}

		}



			if(mouseCube){
				circle1.GetComponent<MeshRenderer>().materials[0].color=myColor;
				circle2.GetComponent<MeshRenderer>().materials[0].color=myColor;
				circle3.GetComponent<MeshRenderer>().materials[0].color=myColor;
				circle4.GetComponent<MeshRenderer>().materials[0].color=myColor;
			}
			else{



		if(transform.position.z>currentMouseCubePos.z){
			if(transform.position.x>currentMouseCubePos.x){
				//topRight
					circle1.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
			}
			else{
				//topLeft
					circle1.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=myColor;
			}
		}
		else if(transform.position.z<currentMouseCubePos.z){
			if(transform.position.x>currentMouseCubePos.x){
				//bottomRight
					circle1.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=myColor;
			}
			else{
				//bottomLeft
					circle1.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
			}
		}
		else if(transform.position.x==currentMouseCubePos.x){
			if(transform.position.z>currentMouseCubePos.z){
				//above
					circle1.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
			}
			else{
			//	below
					circle1.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=myColor;
			}
		}
		else if(transform.position.z==currentMouseCubePos.z){
			if(transform.position.x>currentMouseCubePos.x){
				//right
					circle1.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=myColor;
			}
			else{
				//left
					circle1.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle2.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
					circle3.GetComponent<MeshRenderer>().materials[0].color=myColor;
					circle4.GetComponent<MeshRenderer>().materials[0].color=oppositeColor;
			}
		}







			}

		/*
		if(white){
			circle1.GetComponent<MeshRenderer>().materials[0].color=cubeBlack;
			circle2.GetComponent<MeshRenderer>().materials[0].color=cubeBlack;
			circle3.GetComponent<MeshRenderer>().materials[0].color=cubeBlack;
			circle4.GetComponent<MeshRenderer>().materials[0].color=cubeBlack;
		}
		else{
			circle1.GetComponent<MeshRenderer>().materials[0].color=cubeWhite;
			circle2.GetComponent<MeshRenderer>().materials[0].color=cubeWhite;
			circle3.GetComponent<MeshRenderer>().materials[0].color=cubeWhite;
			circle4.GetComponent<MeshRenderer>().materials[0].color=cubeWhite;
		}
		*/
	
	}
}
