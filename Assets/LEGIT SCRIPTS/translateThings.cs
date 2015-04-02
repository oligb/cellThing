using UnityEngine;
using System.Collections;

public class translateThings : MonoBehaviour {

	// Use this for initialization
	public float rotSpeed;
	public float low=0f;
	public float high=4f;
	void Start () {
		rotSpeed=Random.Range (low,high);


		//TWEEN
		//iTween.MoveBy(gameObject, iTween.Hash("z", .5, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", 2));
		//iTween.MoveBy(gameObject, iTween.Hash("x", .5, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", 1));
	}

	
	// Update is called once per frame
	void Update () {

		//transform.Rotate (new Vector3(0f,rotSpeed,0f));
	//
	}


}
