using UnityEngine;
using System.Collections;

public class scaleTween : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//iTweenExtensions.ScaleBy(Vector3(5f,5f,5f),5f,0f,EaseType 

		gameObject.ScaleBy(new Vector3(5f,5f,5f),5f,0f);

	//	iTween.ScaleBy(
	//transform.localScale
	}
}
