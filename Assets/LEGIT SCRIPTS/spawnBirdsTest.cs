using UnityEngine;
using System.Collections;

public class spawnBirdsTest : MonoBehaviour {

	public GameObject bird;
	public int birdNum=5;
	public int currentBirds=0;
	public bool spawnable=true;
	public float minBirdDelay=1f;
	public float maxBirdDelay=10f;
	public Color hsvCol;
	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnTheBirds());
		for(int i=0; i<10; i++){
			Instantiate(bird,new Vector3(Random.Range(-10f,10f),10f,Random.Range(-10f,10f)),Quaternion.identity);
		}

	}


	public IEnumerator SpawnTheBirds(){

		while(spawnable){	
		
		yield return new WaitForSeconds(Random.Range (minBirdDelay,maxBirdDelay));
			if(currentBirds<=birdNum){
			Instantiate(bird,new Vector3(Random.Range(-10f,10f),10f,Random.Range(-10f,10f)),Quaternion.identity);
		
			currentBirds++;
			}
			yield return 0;
		
		}
	}








	// Update is called once per frame
	void Update () {
	
	
	}
}
