using UnityEngine;
using System.Collections;

public class moveObstacle : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject playerGuy;
	public float rotSpeed=5f;
	public bool homing=false;
	public float homingChance=.01f;
	public float homingSpeed=10f;

	public GameObject cubeExplode;
	void Start () {
		transform.localScale=new Vector3(Random.Range (4f,10f),Random.Range (4f,10f),Random.Range (4f,10f));
		player=GameObject.Find ("PlayerHolder");
		playerGuy=GameObject.Find("guy");
	}
	
	// Update is called once per frame
	void Update () {


		if(transform.position.z-playerGuy.transform.position.z>50f){
			float homingRando=Random.Range (0f,100f);
			if(homingRando<=homingChance){
				homing=true;
			}
		}
		else{
			homing=false;
		}

	//	if(homing && (int)Time.time%4==0){
			if(homing){
			Vector3 tPos= player.transform.position;
			tPos.z+=30f;
			transform.LookAt(tPos);
			transform.Translate(Vector3.forward*homingSpeed);
		}
		else{
			
			transform.Rotate (new Vector3(rotSpeed/2,rotSpeed,0f));

		}
		if((transform.position.z+5f)<=player.transform.position.z){

			Destroy(gameObject);

	}
	}

	void OnCollisionEnter(Collision col){
		/*
		if(col.gameObject.name=="Cylinder"){
			player.GetComponent<MoveTrails2>().killedCube();
		Instantiate(cubeExplode,transform.position,Quaternion.identity);
		Destroy(gameObject);
		}
		else if (col.gameObject.name=="cube"){
			player.GetComponent<MoveTrails2>().killedCube();
			Instantiate(cubeExplode,transform.position,Quaternion.identity);
			player.GetComponent<MoveTrails2>().hitCube();
*/
		Instantiate(cubeExplode,transform.position,Quaternion.identity);
		Destroy(gameObject);
		}

}
