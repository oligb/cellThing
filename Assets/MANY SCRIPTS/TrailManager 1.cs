using UnityEngine;
using System.Collections;

public class TrailManager : MonoBehaviour {

	public float val1;
	public float val2;
	public float time1;
	public float time2;
	
	IEnumerator Start()
	{
		
		while (true) {
			yield return StartCoroutine(TweenValue( val1,val2,time1));
			yield return StartCoroutine(TweenValue( val2,val1,time2));
		}
	}
	
	IEnumerator TweenValue(float val1,float val2, float time)
	{
		GameObject camera=GameObject.Find("Main Camera");
		float i= 0f;
		float rate= 1f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			GetComponent<TrailRenderer>().endWidth = Mathf.Lerp(val1,val2,i);

			yield return null; 
		}
	}
}	