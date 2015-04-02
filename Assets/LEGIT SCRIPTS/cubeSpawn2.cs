using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cubeSpawn2 : MonoBehaviour {
	
	public GameObject cube;
	public Vector3 cubeRotation;
	
	
	// Use this for initialization
	void Start () {
		
		for(int i=0;i<20;i+=1){
			for(int j=0;j<20;j+=1){
				GameObject cubelet= Instantiate(cube, new Vector3((float)i,0f,(float)j), Quaternion.Euler(cubeRotation)) as GameObject;
				//cubelet.manager=gameObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
