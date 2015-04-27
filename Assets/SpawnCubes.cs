using UnityEngine;
using System.Collections;

public class SpawnCubes : MonoBehaviour {

	public GameObject bigCube;
	public GameObject smallCube;
	public GameObject verySmallCube;
	public GameObject kinectCube;
	public Vector3 spawnPos;
	public bool bigCubes=true;

	public float spacing;
	public float sizeX,sizeY,sizeZ;
	// Use this for initialization
	void Start () {
		SpawnWithVariables();

		/*
		if(bigCubes){
		SpawnBigs();
		}
		else{
		SpawnSmalls();
		}
		*/
	
	}

	void SpawnWithVariables(){
		for(float i =spawnPos.x; i<=sizeX; i+=spacing){
			for (float j=spawnPos.y; j<=sizeY; j+=spacing){
				for (float k =spawnPos.z; k<=sizeZ; k+=spacing){
					Instantiate(kinectCube,new Vector3(i,j,k),Quaternion.identity);
				}
			}
		}
	}


	void SpawnBigs(){
		for(float i =-3f; i<4f; i++){
			for (float j=0f; j<2.5f; j++){
				for (float k = -3.5f; k<4.5f; k++){
					Instantiate(bigCube,new Vector3(spawnPos.x+i,spawnPos.y+j,spawnPos.z+k),Quaternion.identity);
				}
			}
		}
	}
	void SpawnSmalls(){
		for(float i =0f; i<1f; i+=.4f){
			for (float j=0f; j<1f; j+=.4f){
				for (float k = 0f; k<1f; k+=.4f){
					Instantiate(smallCube,new Vector3(spawnPos.x-1f+i,spawnPos.y+j,spawnPos.z+k),Quaternion.identity);
				}
			}
		}


		for(float i =0f; i<.2f; i+=.05f){
			for (float j=0f; j<.2f; j+=.05f){
				for (float k = 0f; k<.2f; k+=.05f){
					Instantiate(verySmallCube,new Vector3(spawnPos.x+1f+i,spawnPos.y+j,spawnPos.z+k),Quaternion.identity);
				}
			}
		}


	}

	// Update is called once per frame
	void Update () {
	
	}
}
