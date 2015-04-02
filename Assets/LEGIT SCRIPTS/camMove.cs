using UnityEngine;
using System.Collections;

public class camMove : MonoBehaviour {

	// Use this for initialization
	public float speed=5f;
	public GameObject cardboard;
	public float slerpAmt=.5f;
	void Start () {
		cardboard=GameObject.Find("Head");
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.forward*speed);
		//transform.rotation= Quaternion.Euler(cardboard.transform.rotation.eulerAngles);
		transform.rotation= Quaternion.Slerp(transform.rotation,cardboard.transform.rotation,slerpAmt);
	}
}
 	