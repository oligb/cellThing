using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {

	// Use this for initialization
	public GameObject LR;
	public GameObject UD;
	public float inputScale=10f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX=Input.GetAxis("Horizontal")*inputScale;
		float inputY=Input.GetAxis("Vertical")*inputScale;
		LR.transform.position+= new Vector3(inputX,0f,0f);
		UD.transform.position+= new Vector3(0f,inputY,0f);
	}

	void RandomizePos(){
		LR.transform.localPosition=new Vector3(Random.Range (-500f,500f),0f,0f);
		UD.transform.localPosition=new Vector3(0f,Random.Range (-500f,500f),0f);
	}
}
