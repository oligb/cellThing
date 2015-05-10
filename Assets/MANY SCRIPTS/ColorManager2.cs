using UnityEngine;
using System.Collections;

public class ColorManager2 : MonoBehaviour {
	
	// Use this for initialization
	
	public float sphereHue=.2f;
	public float traileHue=.2f;
	public float traileHue2=.2f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		sphereHue=MidiInput.GetKnob(4, MidiInput.Filter.Slow);
		traileHue=MidiInput.GetKnob(5, MidiInput.Filter.Slow);
		traileHue2=MidiInput.GetKnob(6, MidiInput.Filter.Slow);


		if(Input.GetKeyDown("space")){
			sphereHue=Random.Range(0f,1f);
			traileHue=Random.Range(0f,1f);
			traileHue2=Random.Range(0f,1f);
		}
		
	}
}
