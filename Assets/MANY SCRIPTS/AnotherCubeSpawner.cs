using UnityEngine;
using System.Collections;

public class AnotherCubeSpawner : MonoBehaviour {

	// Use this for initialization
	public float radius=5f;
	public GameObject cube;
	public float moveSpeed;
	public Vector3 targetPos;
	public Vector3 rotVector;
	void Start () {
		//radius=Random.Range(5f,20f);
		targetPos = Random.onUnitSphere*radius;

		//Vector3 targetPos=Vector3.forward*radius;
		GameObject tCube= Instantiate(cube,transform.localPosition,Quaternion.identity) as GameObject;
		transform.LookAt(targetPos);
		tCube.GetComponent<AnotherCubeController>().CallCoroutine(targetPos,moveSpeed);

		tCube.transform.parent=gameObject.transform;	

		float upOrDown=Random.Range(0f,1f);
		if(upOrDown>.5f){
			rotVector.x=Random.Range(-30f,-20f);
		}
		else{
			rotVector.x=Random.Range(20f,30f);
		}


		//transform.localScale=Random.Range(2f,5f)*Vector3.one;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
