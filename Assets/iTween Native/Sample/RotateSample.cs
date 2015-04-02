using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{	public float rotateAmt;
	public float delayAmt;
	public float timeAmt=1f;
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("x", rotateAmt,"time", timeAmt, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", delayAmt));
	}
}

