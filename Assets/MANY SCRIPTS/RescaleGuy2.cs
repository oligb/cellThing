using UnityEngine;
using System.Collections;

public class RescaleGuy2 : MonoBehaviour {
	
	// Use this for initialization
	public float scaleSpeed=.1f;
	public TrailRenderer trail;
	
	public float perlinPos;
	public float perlinInc=.1f;
	public float additionalPerlin =0f;
	public float perlinScale=.5f;
	public float holderRotScaler;
	void Start () {
		
		perlinPos=Random.Range(0f,1000f);
		trail=GetComponent<TrailRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float scale =  (.5f -Mathf.PerlinNoise(perlinPos,0f))*(perlinScale+additionalPerlin);
		Vector3 scaleVector= scale * Vector3.one;
		
		//Vector3 scale=transform.localScale= (.5f -Mathf.PerlinNoise(perlinPos,0f))*Vector3.one*perlinScale;
		transform.localScale=scaleVector;
		trail.startWidth=scale*2f;
		trail.time=scale;

		holderRotScaler=GetComponent<GetValues>().holderRotScaler;
		transform.parent.gameObject.GetComponent<SpawnCube5>().rotSpeed=scale+holderRotScaler;
		
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
