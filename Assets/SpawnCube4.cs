using UnityEngine;
using System.Collections;

public class SpawnCube4 : MonoBehaviour {
	
	public GameObject cube;
	public float rotSpeed=1f;
	public float radius =5f;
	public float moveOutSpeed=.5f;
	public int rotType;
	// Use this for initialization
	void Start () {
		Vector3 targetPos = Random.onUnitSphere*radius;
		//Vector3 targetPos=Vector3.forward*radius;
		
		GameObject tCube= Instantiate(cube,transform.localPosition,Quaternion.identity) as GameObject;
		
		tCube.transform.parent=gameObject.transform;
		tCube.GetComponent<CubeController>().CallCoroutine(targetPos,moveOutSpeed);
		transform.LookAt(tCube.transform.position);
		
		rotType=Random.Range (1,3);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(rotType==1){
			transform.Rotate(new Vector3(1f,-rotSpeed,-rotSpeed));
		}
		else if(rotType==2){
			transform.Rotate(new Vector3(1f,rotSpeed,-rotSpeed));
		}
		else if(rotType==3){
			transform.Rotate(new Vector3(-1f,-rotSpeed,-rotSpeed));
		}
		

	}
}
