using UnityEngine;
using System.Collections;

public class destroyParticle : MonoBehaviour {

	// Use this for initialization
	public float startTime;
	void Start () {
		startTime=Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(startTime-Time.time<=-3f){
			Destroy(gameObject);
		}
	
	}
}
