﻿
using UnityEngine;
using System;  // Needed for Math

public class TestingAudio : MonoBehaviour
{
  // un-optimized version
  public double frequency = 440;
  public double gain = 0.05;

	public double increment=.05f;
  public double phase;
  public double sampling_frequency = 48000;
	public int datalength;

  void OnAudioFilterRead(float[] data, int channels)
  {
		datalength=data.Length;
    // update increment in case frequency has changed
  //  increment = frequency * 2 * Math.PI / sampling_frequency;
    for (var i = 0; i < data.Length; i = i + channels)
    {
      phase = phase + increment;
    // this is where we copy audio data to make them “available” to Unity
	 
      data[i] = (float)(gain*Math.Sin(phase));
    // if we have stereo, we copy the mono data to each channel
      if (channels == 2) data[i + 1] = data[i];
      if (phase > 2 * Math.PI) phase = 0;
    }
  }
}  