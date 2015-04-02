using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirdStats : MonoBehaviour {

	// Use this for initialization
	public float age=1f;
	public float ageRate=.01f;
	public bool male = true;
	public float feistyness=10f;
	public Color birdColor;
	public GameObject birdManager;
	public List<GameObject> birdList;

	public bool crazyMode=false;


	public int currentPos;
	public List<Vector3> positions;
	public bool onPerch;
	public bool moving=false;
	public float likelihoodToMovePerFrame=1f;
	public int target;

	public float distToCheckTarget=1f;
	public bool gonnaFight = false;
	public GameObject otherBird;
	public Animator animator;

	public bool takingOff=false;
	void Start () {
		GetComponentInChildren<SkinnedMeshRenderer>().materials[0].color = HSVToRGB(Random.Range (0f,1f),.5f,.9f);


		//GetComponent<MeshRenderer>().materials[0].color=birdColor;
		animator=GetComponentInChildren<Animator>();
		float rando=Random.Range(0f,100f);
		if(rando<=50f){
			male=false;
		}
		feistyness = Random.Range(0f,10f);


		birdManager=GameObject.Find("BirdManager");
		positions=birdManager.GetComponent<BirdManager>().birdPerches;
		birdList=birdManager.GetComponent<BirdManager>().birdList;
		birdList.Add(gameObject);

		target=Random.Range (0,positions.Count);
		MoveBirdDirectly(target);
		takingOff=false;

		animator.Play("flap");

	}
	
	// Update is called once per frame
	void Update () {
		age += ageRate;
		
		float chanceRando=Random.Range(0f,100f);
		if (chanceRando<=likelihoodToMovePerFrame && !moving){
			
			//animator.SetTrigger("takeOffTrigger");
			animator.Play("takeoff");
			target=Random.Range (0,positions.Count);
			MoveBirdDirectly(target);
			takingOff=true;
			Invoke ("ToggleTakeOff",.2f);
			//StartCoroutine(BirdInFlight());
			//	StartCoroutine(MoveBirdDirectly(target));
		}



		if(transform.position==positions[target]){

			currentPos=target;
			moving=false;
		}


		if(moving){
			transform.LookAt(positions[target]);
			if(Vector3.Distance(transform.position,positions[target])<=distToCheckTarget && !takingOff){
				otherBird=CheckTarget();
				StartCoroutine(RotateToLand());
				
				//animator.SetTrigger("landTrigger");
				animator.Play("land");
				if(otherBird != null){

					if(feistyness>=otherBird.GetComponent<BirdStats>().feistyness){
						otherBird.GetComponent<BirdStats>().KillBird();
						//gonnaFight=false;
					}
					else{
						KillBird();
					}
					
				}

			}

		}
	



	}
	public void ToggleTakeOff(){
		animator.SetTrigger("startFlapping");

		takingOff=false;
	}

	public IEnumerator RotateToLand(){
		int i =0;
		int degsToRotate=30;
		bool dir;
		if(transform.rotation.eulerAngles.x<50){
		dir=false;
		}
		else{
		dir=true;
		}
		while(i<degsToRotate){
			if(dir){
			transform.RotateAround(transform.position, transform.right, 1f);
			}
			else{
			transform.RotateAround(transform.position, transform.right, -1f);
			}

			i++;
			yield return 0;
		}
	}


	public GameObject CheckTarget(){
	foreach(GameObject bird in birdList){
			if(bird.GetComponent<BirdStats>().currentPos==target){
				//gonnaFight=true;
				return bird;
			   }
		}
		return null;

	}

	public IEnumerator BirdInFlight(){
	
		while(moving){
			transform.LookAt(positions[target]);
			yield return 0;
		}
	
	}

	public void KillBird(){
		birdManager.GetComponent<spawnBirdsTest>().currentBirds-=1;
		birdList.Remove(gameObject);
		float randoFate=Random.Range (0f,1f);


		if(crazyMode){
		if(randoFate<.5f){
			GetComponent<KillBird>().ReallyKillBird(true);
		}
		else{
			GetComponent<KillBird>().ReallyKillBird(false);
		}

		}

		GetComponent<Rigidbody>().isKinematic=false;
		GetComponent<BirdStats>().enabled=false;
		//Destroy(gameObject);
	}



	public void MoveBirdDirectly(int target){
		moving=true;
		gameObject.MoveTo(positions[target],4f,0f);
	}


	public static Color HSVToRGB(float H, float S, float V)
	{
		if (S == 0f)
			return new Color(V,V,V);
		//else if (V == 0f)
		//	return new Color.black;
		else
		{
			Color col = Color.black;
			float Hval = H * 6f;
			int sel = Mathf.FloorToInt(Hval);
			float mod = Hval - sel;
			float v1 = V * (1f - S);
			float v2 = V * (1f - S * mod);
			float v3 = V * (1f - S * (1f - mod));
			switch (sel + 1)
			{
			case 0:
				col.r = V;
				col.g = v1;
				col.b = v2;
				break;
			case 1:
				col.r = V;
				col.g = v3;
				col.b = v1;
				break;
			case 2:
				col.r = v2;
				col.g = V;
				col.b = v1;
				break;
			case 3:
				col.r = v1;
				col.g = V;
				col.b = v3;
				break;
			case 4:
				col.r = v1;
				col.g = v2;
				col.b = V;
				break;
			case 5:
				col.r = v3;
				col.g = v1;
				col.b = V;
				break;
			case 6:
				col.r = V;
				col.g = v1;
				col.b = v2;
				break;
			case 7:
				col.r = V;
				col.g = v3;
				col.b = v1;
				break;
			}
			col.r = Mathf.Clamp(col.r, 0f, 1f);
			col.g = Mathf.Clamp(col.g, 0f, 1f);
			col.b = Mathf.Clamp(col.b, 0f, 1f);
			return col;
		}
	}



	
}
