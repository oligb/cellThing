using UnityEngine;
using System.Collections;

public class SetValues : MonoBehaviour {

	// Use this for initialization
	public float trailStart;
	public float trailEnd;
	public float trailTime;
	public float perlinScale=1f;
	public float perlinScaleScaler=1f;
	public float holderRotSpeeds=15f;
	public float wholeThingRotSpeed=100f;
	public float wholeThingRotSpeedScale;
	public GameObject playerObject;
	public float holderRotScaler;
	public float wholeThingScaler=5f;
	public float camOffset=30f;
	public float maxScale=20f;
	public float timeCounter=0f;
	public float extraScale=5f;
	public float delayTime;

	public float modIndexScale=3f;
	public float perlinRange=2000f;
	void Start () {
		playerObject=GameObject.Find("PlayerObject");
	}
	
	// Update is called once per frame
	void Update () {

		delayTime=(GetComponent<AudioEchoFilter>().delay)/1000f;
		if(delayTime==0){
			delayTime=5f;
		}
		timeCounter+=Time.deltaTime;

		float addExtraScale= (timeCounter/delayTime)*extraScale;

		if(timeCounter>=delayTime){
			timeCounter=0f;
		}

		wholeThingRotSpeed=Mathf.Clamp(MidiInput.GetKnob(1, MidiInput.Filter.Fast),.1f,1f)*wholeThingRotSpeedScale;
	//	perlinScale=MidiInput.GetKnob(2, MidiInput.Filter.Fast)*perlinScaleScaler+addExtraScale;


		GetComponent<Sawtooth>().modulatingIndex=MidiInput.GetKnob(3, MidiInput.Filter.Fast)*modIndexScale;
		GetComponent<Sawtooth>().perlinScale=MidiInput.GetKnob(4, MidiInput.Filter.Fast)*perlinRange;



		perlinScale=MidiInput.GetKnob(2, MidiInput.Filter.Fast)*perlinScaleScaler;
		playerObject.GetComponent<CoroutineCenter2>().addedRotation=wholeThingRotSpeed;
		playerObject.transform.localScale=Mathf.Clamp( MidiInput.GetKnob(8, MidiInput.Filter.Fast)*wholeThingScaler,1f,maxScale) *Vector3.one;
		//Camera.main.transform.localPosition=new Vector3(0f,0f,Mathf.Clamp(MidiInput.GetKnob(8, MidiInput.Filter.Fast),.5f,.7f)-camOffset);
	}
}
