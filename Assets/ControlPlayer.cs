using UnityEngine;
using System.Collections;

public class ControlPlayer : MonoBehaviour {

	// Use this for initialization
	public bool onGrapple=true;
	public float rotateSpeedX=5f;
	public float rotateSpeedY=5f;
	public float coroutineSpeed;
	public float coroutineDistance;
	public Transform endpoint;
	public Transform rootCube;
	public GameObject holder;

	void Start () {
		holder=GameObject.Find("holder");
		rootCube=GameObject.Find ("RootCube").transform;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.C)){
			holder.BroadcastMessage("OffGravity");
			Vector3 vel=GameObject.Find("endCube").GetComponent<Rigidbody>().velocity;
			GetComponent<Rigidbody>().velocity=vel;
			Camera.main.GetComponent<followPlayer>().endCube=transform;
			holder.SetActive(false);
			onGrapple=false;
			GetComponent<FakeGravity>().enabled=false;

		}

		float inputX=Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeedX;
		float inputY=Input.GetAxis("Vertical")*Time.deltaTime*rotateSpeedY;

		if(onGrapple){
			transform.position=endpoint.position+Vector3.down/2;
		}
		else{

		}
//		transform.Rotate(new Vector3(inputY,inputX,0f));

		//transform.LookAt(new Vector3(rootCube.position.x, transform.position.y, rootCube.position.z));
		transform.LookAt(rootCube.position);
	
	}
	public IEnumerator MoveTowardsEndpoint(){
	//	while(Vector3.Distance(endpoint.position,transform.position)>coroutineDistance){
		while(true){
			//	transform.LookAt(targetPos);
			Vector3 moveDir=endpoint.position-transform.position;
			transform.Translate(moveDir*coroutineSpeed);
			yield return 0;
		}
		
	}
}
