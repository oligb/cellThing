using UnityEngine;
using System.Collections;

public class ColorController : MonoBehaviour {

	// Use this for initialization
	public float perlinScale=1f;
	public float perlinYScroll=0f;
	public float perlinXScroll=0f;
	public float xScrollSpeed=1f;
	public float yScrollSpeed=1f;
	public float saturation=1f;
	public float value=1f;
	
	public float perlinVal2;
	public float perlinInc2=.01f;
	public float scaleScaler=100f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//perlinScale=Mathf.Lerp(1f,15f,MidiInput.GetKnob(1,MidiInput.Filter.Slow));

		float perlinMod=.5f-Mathf.PerlinNoise(perlinVal2,0f);
		xScrollSpeed=perlinMod/scaleScaler;
		yScrollSpeed=perlinMod/scaleScaler;
		perlinXScroll+=xScrollSpeed;
		perlinYScroll-=yScrollSpeed;
		perlinVal2+=perlinInc2;
	}
}
