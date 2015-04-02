using UnityEngine;
using System.Collections;

public class addToList : MonoBehaviour {

	// Use this for initialization
	public GameObject birdManager;
	void Start () {
		birdManager=GameObject.Find("BirdManager");
		birdManager.GetComponent<BirdManager>().birdPerches.Add(transform.position);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
