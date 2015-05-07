using UnityEngine;
using System.Collections;

public class MidiInputSound : MonoBehaviour {

	// Use this for initialization
	public float delayScale=2000f;
	public float lowPassScale=7000f;

	public float freqScale=5000f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Sawtooth>().frequency=MidiInput.GetKnob(7, MidiInput.Filter.Fast)*freqScale;
		GetComponent<AudioEchoFilter>().delay=MidiInput.GetKnob(1, MidiInput.Filter.Fast)*delayScale;
		GetComponent<AudioEchoFilter>().decayRatio=MidiInput.GetKnob(2, MidiInput.Filter.Fast);
		GetComponent<AudioEchoFilter>().wetMix=MidiInput.GetKnob(3, MidiInput.Filter.Fast);
		GetComponent<AudioEchoFilter>().dryMix=MidiInput.GetKnob(4, MidiInput.Filter.Fast);
		GetComponent<AudioLowPassFilter>().cutoffFrequency=MidiInput.GetKnob(5, MidiInput.Filter.Fast)*lowPassScale;
		GetComponent<AudioLowPassFilter>().lowpassResonanceQ=MidiInput.GetKnob(6, MidiInput.Filter.Fast)*10f;
		//=MidiInput.GetKnob(1, MidiInput.Filter.Slow);

	}
}
