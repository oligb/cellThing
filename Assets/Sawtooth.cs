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
	
	void OnAudioFilterRead(float[] data, int channels)
	{
		// update increment if case of frequency as change
		increment = frequency * 2f * (float)Math.PI / sampling_frequency;
		for (int i = 0; i < data.Length; i = i + channels)
		{
			phase = phase + increment;
			//data[i] = (float)(gain*Math.Sin(phase));
			
			data[i] = 2f*(phase-(float)Math.Floor(phase))*gain;
			
			if (channels == 2) data[i + 1] = data[i];
			if (phase > 2f * Math.PI) phase = 0f;
		}
	}
}