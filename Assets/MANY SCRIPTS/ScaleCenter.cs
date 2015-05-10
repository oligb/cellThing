using UnityEngine;
using System.Collections;

public class ScaleCenter : MonoBehaviour {

	// Use this for initialization
	public float scaleSpeed=1f;
	public Vector3 startScale;
	void Start () {
		startScale=transform.localScale;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.O)){
			Vector3 scaleTemp=transform.localScale+=Vector3.one*scaleSpeed;
			transform.localScale=scaleTemp;
		}
		else if(Input.GetKey(KeyCode.L)){
			Vector3 scaleTemp=transform.localScale-=Vector3.one* scaleSpeed;
			transform.localScale=scaleTemp;
		}

		if(Input.GetKeyDown("space")){
			transform.localScale=startScale;
		}
	}
}
