using UnityEngine;
using System.Collections;

public class TestMidi : MonoBehaviour {

	public float val;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		val=MidiInput.GetKnob(1, MidiInput.Filter.Realtime);
	}
}
