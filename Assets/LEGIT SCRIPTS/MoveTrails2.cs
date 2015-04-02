using UnityEngine;
using System.Collections;

public class MoveTrails2 : MonoBehaviour {
	
	
	public float rotSpeed=5f;
	public float perlinScale=.5f;
	public float perlinInc=.1f;
	public float perlinSpeed=1f;
	public float moveScale;
	public float moveScaleScaler=5f;

	public float inputScale=1f;
	public bool lazering=false;
	public bool canLazer=true;
	public float lazerSpeed=.5f;
	// Use this for initialization
	public GameObject cam;
	public GameObject lazerHolder;
	void Start () {
		lazerHolder=GameObject.Find("LazerHolder");
		cam=GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 perlinVector= new Vector3(Mathf.PerlinNoise(perlinInc/perlinSpeed,0f),Mathf.PerlinNoise(0f,perlinInc/perlinSpeed),0f);
		Vector3 perlinVector= new Vector3(.5f-Mathf.PerlinNoise(perlinInc/perlinScale,0f),0f,0f);
		

		//transform.localPosition=perlinVector*moveScale;
		float inputX= Input.GetAxis("Horizontal")*inputScale;
		float inputY= Input.GetAxis("Vertical")*inputScale;
		cam.transform.localPosition+=new Vector3(inputX,inputY,0f);
		transform.localPosition+=new Vector3(inputX,inputY,0f);
		transform.Rotate (new Vector3(0f,0f,transform.position.x*rotSpeed));

	//	transform.Rotate (new Vector3(0f,0f,perlinVector.x*rotSpeed));

		/*
		moveScale=Mathf.PerlinNoise(perlinInc/perlinScale,0f)*moveScaleScaler;

		float inputX= Input.GetAxis("Horizontal")*moveScale;
		transform.localPosition=new Vector3(inputX,0f,0f);
		//transform.Rotate (new Vector3(0f,0f,inputX*rotSpeed));
		Vector3 spinVector = new Vector3(0f,0f,inputX*rotSpeed);
		transform.rotation= Quaternion.Euler(spinVector);
		*/
		/*
		moveScale=Mathf.PerlinNoise(perlinInc/perlinScale,0f)*moveScaleScaler;
		float inputX= Input.GetAxis("Horizontal")*moveScale;
		float inputY= Input.GetAxis("Vertical")*moveScale;
		transform.Translate(new Vector3(inputX,inputY,0f));
		transform.Rotate (new Vector3(0f,0f,inputX*rotSpeed));
		//transform.Rotate (new Vector3(0f,0f,inputX*rotSpeed));

*/
		
		//transform.LookAt(cardboard.transform.position);
		perlinInc+=perlinSpeed;


		if (Input.GetKey("space")){
			StopCoroutine("ShrinkLazer");
			lazering=true;
		}
		else{
			lazering=false;
			canLazer=true;
			StartCoroutine("ShrinkLazer");
		}

		if(lazering&&canLazer){
			canLazer=false;
			StartCoroutine("TheLazer");
		}

		
	}

	public void killedCube(){
	}
	public void hitCube(){
	}
	IEnumerator TheLazer(){

		while(lazering){
			
			lazerHolder.transform.localScale+=new Vector3(0f,lazerSpeed,0f);
			yield return 0;

	}

}
	IEnumerator ShrinkLazer(){
		
		while(lazerHolder.transform.localScale.y>=0){
			
			lazerHolder.transform.localScale-=new Vector3(0f,lazerSpeed,0f);
			yield return 0;
			
		}
		
	}
}
