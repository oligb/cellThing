using UnityEngine;
using System.Collections;

public class CamMove3 : MonoBehaviour {
	
	public float speed=5f;
	public float inputScale=1f;
	public GameObject cardboardCam;
	public GameObject player;
	void Start () {
		player=GameObject.Find ("guy");

		cardboardCam=GameObject.Find("CardboardMain");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.forward*speed);

		float inputX= cardboardCam.transform.localRotation.eulerAngles.x*inputScale;
		float inputY= cardboardCam.transform.localRotation.eulerAngles.y*inputScale;
		float inputZ= cardboardCam.transform.localRotation.eulerAngles.z*inputScale;
		transform.rotation= Quaternion.Euler(new Vector3( inputX,  inputY,inputZ));
		player.transform.Rotate(new Vector3(0f,inputX,0f));
		Vector3 tRot=transform.rotation.eulerAngles;
	//	tRot.z=0f;
		//transform.rotation= Quaternion.Euler ( tRot);

		
	}
}
