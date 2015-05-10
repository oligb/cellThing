using UnityEngine;
using System.Collections;

public class scaleTweenNonsense : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.ScaleBy(Vector3.up,5f,0f,EaseType.easeInCubic,LoopType.pingPong);
		gameObject.ScaleBy(Vector3.right,3f,0f,EaseType.easeInCubic,LoopType.pingPong);
		gameObject.ScaleBy(Vector3.forward,2f,0f,EaseType.easeInCubic,LoopType.pingPong);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
