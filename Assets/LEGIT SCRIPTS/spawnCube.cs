using UnityEngine;
using System.Collections;

public class spawnCube : MonoBehaviour {
	public GameObject cubelet;
	public float timeCubes;
	public bool spawn=true;
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnIt",0f,timeCubes);
		//Time.timeScale=.01f;

	}
	void SpawnIt(){
		if(spawn){
		GameObject cubelette= Instantiate(cubelet, Vector3.zero, Quaternion.identity) as GameObject;
		}
		//cubelette.transform.localScale= new Vector3(Random.Range(0f,3f), Random.Range(0f,3f),Random.Range(0f,3f));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
