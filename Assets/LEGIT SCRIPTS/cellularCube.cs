using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class cellularCube : MonoBehaviour {

	public bool moving=true;
	public int direction;
	public List<Vector3> dirs = new List<Vector3>();
	private float magnitude=5f;
	public float startingMagnitude=10f;
	private float slowDown=0f;
	public float falloffAmt=.1f;
	public float rotateAmt=5f;

	public float moveTime=0f;
	public float moveSpeed=.5f;

	void Start () {
		InvokeRepeating("moveCube",1,moveTime);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotate = new Vector3(rotateAmt+Random.Range(0,5),rotateAmt+Random.Range(0,5),rotateAmt+Random.Range(0,5));
		transform.Rotate(rotate);
		if(moving){

			//transform.Translate(move);

		}



	}
	void moveCube(){
		direction=Random.Range(0,3);
		magnitude=Mathf.Lerp(startingMagnitude,0,slowDown);
		//slowDown+=falloffAmt;
		Vector3 movement= dirs[direction]*magnitude;

		//TWEEN

		iTween.MoveBy(gameObject, iTween.Hash("x", movement.x,"y",movement.y,"z",movement.z, "easeType", "easeInOutExpo", "delay", .1));
		iTween.MoveBy(gameObject, iTween.Hash("amount", movement, "time",moveSpeed));
		//yield WaitForSeconds(2f);
		//moving=false;
	}
}
