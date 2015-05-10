using UnityEngine;
using System.Collections;

public class ShootGrapple : MonoBehaviour {

	// Use this for initialization
	public HingeJoint grappleSpring;
	public GameObject grappleHolder;
	public bool shooting=false;
	public float shotSpeed=5f;
	public Transform endCube;
	public GameObject holder;
	
	void Start () {
		holder=GameObject.Find("holder");
		endCube=GameObject.Find ("endCube 1").transform;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("space")){
			if(GetComponent<ControlPlayer>().onGrapple==false){
				Camera.main.GetComponent<followPlayer>().endCube=endCube;

			shooting=true;
				Invoke ("ActivateHolder",.3f);
			
			Grapple();
			
			}
			else{
				shooting=true;
				GetComponent<FakeGravity>().enabled=true;
				Grapple();
			}

		}
	
	}
	void ActivateHolder(){
		holder.SetActive(true);
		GetComponent<ControlPlayer>().onGrapple=true;
		holder.BroadcastMessage("OnGravity");
	}

	void Grapple(){

		GameObject hook=Instantiate(grappleHolder,endCube.position, transform.rotation) as GameObject;
		hook.GetComponent<GrappleManager>().ShootHook();


	}


}
