using UnityEngine;
using System.Collections;

public class GetValues : MonoBehaviour {

	// Use this for initialization
	public SetValues setValues;
	public GameObject playerObject;
	public TrailRenderer trail;
	public float startPerlin;
	public float holderRotScaler;
	void Start () {
		trail= GetComponent<TrailRenderer>();
		playerObject=GameObject.Find("PlayerObject");
		startPerlin= GetComponent<RescaleGuy2>().perlinScale;
	}
	
	// Update is called once per frame
	void Update () {
		setValues=GameObject.Find("manager").GetComponent<SetValues>();
		GetComponent<RescaleGuy2>().perlinScale=setValues.perlinScale;
		//GetComponent<RescaleGuy2>().additionalPerlin=setValues.perlinScale;
		//rotationSpeed
		//transform.parent.gameObject.GetComponent<SpawnCube5>().rotSpeed=setValues.holderRotSpeeds;
		holderRotScaler=setValues.holderRotScaler;
		//trail.startWidth=setValues.trailStart;
		//trail.endWidth=setValues.trailEnd;
		//trail.time=setValues.trailTime;

		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel("newCoroutineCenterScene");
		}

	
	}
}
