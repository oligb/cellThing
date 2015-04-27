using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {

	// Use this for initialization
	public float speed,scale;
	float rando;
	void Start () {
		rando=Random.Range (1f,500f);
	}
	
	// Update is called once per frame
	void Update () {
		speed+=Random.Range (-1f,1f);	
		Vector3 movement=	new Vector3(0f,Mathf.Sin (Time.time+rando)*scale,0f);
		transform.localPosition+=movement;
	
	}
}
