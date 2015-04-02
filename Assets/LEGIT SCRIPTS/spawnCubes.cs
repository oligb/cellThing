using UnityEngine;
using System.Collections;

public class spawnCubes : MonoBehaviour {

	// Use this for initialization
	public GameObject playerHolder;
	public GameObject obstacle;
	public float obstacleRate=.5f;
	void Start () {
		InvokeRepeating("SpawnObstacle",0f,obstacleRate);
	}

	public void SpawnObstacle(){
		Vector3 obstacleLoc = new Vector3(Random.Range( -100f,100f),Random.Range(-100f,100f),playerHolder.transform.position.z+Random.Range(500f,1000f));
		Instantiate(obstacle,obstacleLoc,Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
