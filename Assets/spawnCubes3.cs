using UnityEngine;
using System.Collections;

public class spawnCubes3 : MonoBehaviour {

	// Use this for initialization
	public GameObject cube;
	void Start () {
		for(int i=0; i<200;i++){
			GameObject cubes=Instantiate(cube,new Vector3(Random.Range (-60f,60f),Random.Range(0f,15f),Random.Range(-50f,50f)),Quaternion.identity) as GameObject;
			cubes.transform.localScale=Vector3.one*Random.Range(3f,5f);
			            }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
