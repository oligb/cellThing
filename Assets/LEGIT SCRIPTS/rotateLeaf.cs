using UnityEngine;
using System.Collections;

public class rotateLeaf : MonoBehaviour {

	// Use this for initialization
	public float current=0f;
	public float increment=.1f;
	public float moveScale=1f;
	void Start () {
		current=Random.Range (1,100f);
		increment=Random.Range (.001f,.05f);
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(Mathf.Sin(current),Mathf.Sin(current-100f),0f)*moveScale);
		transform.Rotate(new Vector3(Mathf.Sin(current),Mathf.Sin(current-100f),0f)*moveScale);
		current+=increment;

	}
}
