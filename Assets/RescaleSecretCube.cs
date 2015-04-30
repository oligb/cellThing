using UnityEngine;
using System.Collections;

public class RescaleSecretCube : MonoBehaviour {
	
	// Use this for initialization
	public float cubeScale=.1f;
	public TrailRenderer trail;
	
	public float perlinPos;
	public float perlinInc=.1f;
	public float perlinScale=.5f;
	
	void Start () {
		
		//perlinPos=Random.Range(0f,1000f);
		trail=GetComponent<TrailRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
		float scale = Mathf.PerlinNoise(perlinPos,0f)*perlinScale;
		Vector3 scaleVector= scale * Vector3.one;
		
		//Vector3 scale=transform.localScale= (.5f -Mathf.PerlinNoise(perlinPos,0f))*Vector3.one*perlinScale;
		transform.localScale=scaleVector;
		trail.startWidth=scale;
		//trail.time=scale;
		
		
		perlinPos+=perlinInc;
*/





		float scale = Mathf.PerlinNoise(perlinPos+transform.position.y/perlinScale,0f)+.5f;
		Vector3 scaleVector= scale * Vector3.one*cubeScale;
		transform.localScale=scaleVector;
		
		perlinPos+=perlinInc;
		/*

		if(Input.GetKey(KeyCode.O)){
			Vector3 scale=transform.localScale +=Vector3.one*scaleSpeed;
			transform.localScale=scale;
			trail.startWidth+=scaleSpeed;
		}
		else if(Input.GetKey(KeyCode.L)){
			Vector3 scale=transform.localScale -=Vector3.one*scaleSpeed;
			transform.localScale=scale;
			trail.startWidth-=scaleSpeed;
		}
*/
		
	}
}
