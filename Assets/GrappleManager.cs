using UnityEngine;
using System.Collections;

public class GrappleManager : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public Vector3 contactPoint;
	public Transform rootCube;
	public float distance;
	public LineRenderer line;
	public GameObject cube;
	public float shotSpeed=1f;
	public bool shooting=false;
	public float moveGrappleSpeed=.1f;
	void Start () {
		line=GetComponent<LineRenderer>();
		Invoke("Destroy",5f);
		rootCube=GameObject.Find ("RootCube").transform;
		player=GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
if(line !=null){
		line.SetPosition(0,player.transform.position);
		line.SetPosition(1,transform.position);
		}
	}
	public void ShootHook(){
		shooting=true;
		StartCoroutine(MoveGrapple());
	}

	IEnumerator MoveGrapple(){
		
		while(shooting){
			transform.Translate(Vector3.up*shotSpeed);
			yield return 0;
		}
		yield break;
		
	}
	void OnCollisionEnter(Collision col){
		Destroy (line);
		shooting=false;

		Invoke ("Destroy",1f);
		if(col.gameObject.name !="Player"){
			

		contactPoint = col.contacts[0].point;
			//rootCube.position=contactPoint;
			StartCoroutine(MoveGrapple(rootCube.position,contactPoint));
			/*
			contactPoint.y=15.75f;
			Instantiate(cube,contactPoint,Quaternion.identity);

			Vector3 newDir=(contactPoint-rootCube.position).normalized;

			distance=Vector3.Distance(contactPoint,rootCube.position);


			Vector3 newPos;
			if(distance>10f){

				 newPos=newDir*10f;
			}
				else{
					 newPos=contactPoint;
				}

				rootCube.position=newPos;
			*/
				/*
			contactPoint=(contactPoint-rootCube.position).normalized*10f;
			contactPoint.y=15.74f;

		rootCube.localPosition+=contactPoint;
*/
		}
	}
	IEnumerator MoveGrapple(Vector3 startPos, Vector3 contactPoint){
		float i =0f;
		float distance=Vector3.Distance(startPos,contactPoint);
		while(i<1f){

			rootCube.position=Vector3.Lerp(startPos,contactPoint,i);
			i+=moveGrappleSpeed/distance;
			yield return 0;
		}
	}

	void Destroy(){
		Destroy(gameObject);
	}
}
