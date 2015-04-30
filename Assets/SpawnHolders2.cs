using UnityEngine;
using System.Collections;

public class SpawnHolders2 : MonoBehaviour {

	// Use this for initialization
	public GameObject holder;
	public int numCubes=20;
	void Start () {
		for(int i =0;i<numCubes;i++){
			GameObject tHolder=Instantiate(holder,transform.localPosition,Quaternion.identity) as GameObject;
			tHolder.transform.parent=gameObject.transform;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
