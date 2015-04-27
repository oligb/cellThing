using UnityEngine;
using System.Collections;

public class MidiInputs : MonoBehaviour {

	// Use this for initialization

	public KinectRepulsion repulseScript;
	public TrailRenderer trail;
	void Start () {
		trail=GetComponentInChildren<TrailRenderer>();
		repulseScript=GetComponent<KinectRepulsion>();
	}
	
	// Update is called once per frame
	void Update () {

		trail.startWidth=Mathf.Lerp(-15f,15f,MidiInput.GetKnob(2,MidiInput.Filter.Slow));
		trail.endWidth=Mathf.Lerp(-15f,15f,MidiInput.GetKnob(3,MidiInput.Filter.Slow));
		trail.time=Mathf.Lerp(1f,20f,MidiInput.GetKnob(4,MidiInput.Filter.Slow));
		repulseScript.moveSpeed=Mathf.Lerp(0f,1f,MidiInput.GetKnob(5,MidiInput.Filter.Slow));
		repulseScript.repulseScale=Mathf.Lerp(1f,20f,MidiInput.GetKnob(6,MidiInput.Filter.Slow));
	}
}
