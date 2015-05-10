using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnSquares : MonoBehaviour {

	public List<GameObject> squares = new List<GameObject>();

	public GameObject square;
	public int xNum;
	public int yNum;
	public bool color=true;
	public Material white;
	public Material black;
	// Use this for initialization
	void Start () {
		for(int i=0;i<xNum;i++){
			for(int j=0; j<yNum; j++){
				GameObject cube = Instantiate(square,new Vector3(i,0f,j),Quaternion.identity) as GameObject;
				squares.Add(cube);
				if(color){
					cube.GetComponent<SquareController>().white=true;
					color=false;
				}
				else{
					cube.GetComponent<SquareController>().white=false;
					color=true;
				}
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
