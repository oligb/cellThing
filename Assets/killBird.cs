using UnityEngine;
using System.Collections;

public class KillBird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ReallyKillBird(bool heaven){

		StartCoroutine(DeadBird(heaven));
	}

	public IEnumerator DeadBird(bool heaven){
		
		while(transform.position.y<=10f &&transform.position.y>=-10f){
			if(heaven){
				transform.Translate(0f,.05f,0f);
			}
			else{
				transform.Translate(0f,-.05f,0f);
			} 
			yield return 0;
		}
	}
}
