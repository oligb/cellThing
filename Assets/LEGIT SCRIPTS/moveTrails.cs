using UnityEngine;
using System.Collections;

public class moveTrails : MonoBehaviour {


	public float rotSpeed=5f;
	public float perlinScale=.5f;
	public float perlinInc=.1f;
	public float perlinSpeed=1f;
	public float moveScale;
	public float moveScaleScaler=5f;
	public GameObject cardboard;
	// Use this for initialization
	void Start () {
		cardboard=GameObject.Find("CardboardMain");
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 perlinVector= new Vector3(Mathf.PerlinNoise(perlinInc/perlinSpeed,0f),Mathf.PerlinNoise(0f,perlinInc/perlinSpeed),0f);
		Vector3 perlinVector= new Vector3(.5f-Mathf.PerlinNoise(perlinInc/perlinScale,0f),0f,0f);

		/*
		transform.localPosition=perlinVector*moveScale;
		transform.Rotate (new Vector3(0f,0f,perlinVector.x*rotSpeed));
		*/
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
			perlinInc+=perlinSpeed;

*/

		//transform.LookAt(cardboard.transform.position);



	}
}
