using UnityEngine;
using System.Collections;

public class AnotherTrailManager : MonoBehaviour {

	public Vector3 velocity;
	public TrailRenderer trail;
	public float sizeScale=100f;
	Vector3 previous;
	void Start () {
		trail=transform.GetComponentInChildren<TrailRenderer>();
		previous = transform.position;

		
		//	StartCoroutine( CalcVelocity() );	
		//		StartCoroutine( RecordPoints());
	}
	// Update is called once per frame
	void Update () {

		velocity = (transform.position - previous);
		previous = transform.position;
		
		trail.startWidth=.1f+velocity.magnitude/sizeScale;
	}
}
