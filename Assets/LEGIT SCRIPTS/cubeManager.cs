using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cubeManager : MonoBehaviour {

	public List<GameObject> cubes = new List<GameObject>();
	// Use this for initialization
	public GameObject cuboid;

	public int increment;
	public int numCubes;

	void Start () {
		for(int i=0;i<numCubes;i++){
			GameObject cubeBoy1= Instantiate(cuboid,new Vector3(i,0f,1f),Quaternion.identity) as GameObject;
			GameObject cubeBoy2= Instantiate(cuboid,new Vector3(i,0f,2f),Quaternion.identity) as GameObject;
			GameObject cubeBoy3= Instantiate(cuboid,new Vector3(i,0f,3f),Quaternion.identity) as GameObject;
			GameObject cubeBoy4= Instantiate(cuboid,new Vector3(i,0f,4f),Quaternion.identity) as GameObject;
			GameObject cubeBoy5= Instantiate(cuboid,new Vector3(i,0f,5f),Quaternion.identity) as GameObject;
		}

	//	spawnCubes();
		/*
		for(int i=0; i<numCubes;i+=increment){
				GameObject cubeBoy= Instantiate(cuboid,new Vector3(0f,0f,i),Quaternion.identity) as GameObject;
				cubes.Add(cubeBoy);

			for(int j=0;i<numCubes;j+=increment){

			//	GameObject cubeBoy= Instantiate(cuboid) as GameObject;
			//	cubes.Add(cubeBoy);
			}
		}
				for



			for(int i=0; i<numCubes; i++){
			for(int j=0;i<numCubes;j+=increment){

		GameObject cubeMan = Instantiate(cuboid,new Vector3(j*increment,0f,i*increment),Quaternion.identity) as GameObject;
		//GameObject cubeManRows = Instantiate(cuboid,new Vector3(i*increment,0f,0f),Quaternion.identity) as GameObject;
			//cubes.Add(cubeMan);
			//cubes.Add(cubeManRows);
			}
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {

	}
	void spawnCubes(){

	}
}
