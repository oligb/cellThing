using UnityEngine;
using System.Collections;

public class spinCamera : MonoBehaviour {

	public float timeCounter=0f;
	
	public float speed =5f;
	public float width =10f;
	public float height = 10f;
	
	public float upDown=5f;
	
	
	public Vector3 center= new Vector3(0f,0f,0f);
	
	public GameObject target;
	public GameObject logic;
	
	
	public float size =5f;
	
	public Color innerColor=new Color(0f,0f,0f);
	public Color outerColor=new Color(0f,0f,0f);
	public Color targetColor=new Color(0f,0f,0f);
	
	public float startX=0f;
	public float startZ=0f;
	public float startAngle;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		
		timeCounter+=Time.deltaTime*speed;
		
		/*
				float y=-Mathf.Cos (timeCounter)*width;
				float x=-Mathf.Sin (timeCounter)*height;
				float z=center.z;
		*/
	//	float y=center.y-200f;
		float z=Mathf.Sin (startAngle+timeCounter)*width;
		float x=Mathf.Cos (startAngle+timeCounter)*width;
		transform.position = new Vector3(x,0f,z);
		
		transform.LookAt(new Vector3(0f,0f,0f));
	}
}
