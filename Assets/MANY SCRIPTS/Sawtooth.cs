using UnityEngine;
using System;  // Needed for Math

public class Sawtooth : MonoBehaviour
{
	// un-optimized version
	public float frequency = 440f;
	public float gain = 0.05f;
	
	private float increment;
	private float phase;
	private float sampling_frequency = 48000;

	public int waveType=0;

	public float modulatingIndex=1f;




	public float perlinPos;
	public float perlinInc=.1f;
	public float perlinScale=1000f;
	public float modulatingFrequency=200f;

	void Update(){
		modulatingFrequency=Mathf.PerlinNoise(0f,perlinPos)*perlinScale;
		perlinPos+=perlinInc;
	}
	
	void OnAudioFilterRead(float[] data, int channels)
	{
		// update increment if case of frequency as change
		increment = frequency * 2f * (float)Math.PI / sampling_frequency;
		for (int i = 0; i < data.Length; i = i + channels)
		{
			phase = phase + increment;
			//data[i] = (float)(gain*Math.Sin(phase));

			//saw
			switch(waveType){

			case 0:
			data[i] = (2f*(phase-(float)Math.Floor(phase)))*gain;
			//value = 2f*(t-(float)Math.Floor(t+0.5f));

			//tri
				break;
			case 1:
				data[i] = (1f-4f*(float)Math.Abs(Math.Round(phase-0.25f)-(phase-0.25f) ))*gain;

			//sq
				break;
			case 2:
				data[i] = (Math.Sign(Math.Sin(2f*Math.PI*phase)))*gain;

			//Sin
				break;
			case 3:
				//data[i] = ((float)Math.Sin(2f*Math.PI*phase))*gain;
				//Debug.Log(data[i]);



				data[i] = gain* Mathf.Sin(2f*(float)Math.PI*phase*frequency + modulatingIndex*Mathf.Sin(2f*(float)Math.PI*modulatingFrequency*phase)); 




				break;
			}


			
			if (channels == 2) data[i + 1] = data[i];
			if (phase > 2f * Math.PI) phase = 0f;
		}
	}
}