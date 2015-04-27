using UnityEngine;
using System.Collections;

public class ColorCube : MonoBehaviour {

	// Use this for initialization
	
	public Color col;
	public float perlinVal;
	public float perlinInc;
	public float perlinScale=1f;
	public ColorController colorControl;
	public TrailRenderer trail;
	public Vector3 startPos;
	void Start () {
		startPos=transform.position;
		trail=GetComponent<TrailRenderer>();
		colorControl=GameObject.Find("ColorController").GetComponent<ColorController>();
		/*
		 col= new Color(Random.Range(0f,1f),0f,0f);
		//col= new Color(

		GetComponent<MeshRenderer>().materials[0].color=col;
		*/
	}
	
	// Update is called once per frame
	void Update () {
		perlinScale=colorControl.perlinScale;
		float globalSaturation=colorControl.saturation;
		float globalValue=colorControl.value;
		float xScroll=colorControl.perlinXScroll;
		float yScroll=colorControl.perlinYScroll;

		float xVal=transform.position.x/perlinScale+xScroll;
		float yVal=transform.position.y/perlinScale+yScroll;
		//float xVal=startPos.x/perlinScale+xScroll;
		//float yVal=startPos.y/perlinScale+yScroll;

		perlinVal=Mathf.PerlinNoise(xVal,yVal);
		col= HSVToRGB(perlinVal+.2f,globalSaturation,globalValue);


		//col= new Color(
		
		//GetComponent<MeshRenderer>().materials[0].color=col;
		trail.materials[0].color=col;
	}

	public static Color HSVToRGB(float H, float S, float V)
	{
		if (S == 0f)
			return new Color(V,V,V);
		//else if (V == 0f)
		//	return new Color.black;
		else
		{
			Color col = Color.black;
			float Hval = H * 6f;
			int sel = Mathf.FloorToInt(Hval);
			float mod = Hval - sel;
			float v1 = V * (1f - S);
			float v2 = V * (1f - S * mod);
			float v3 = V * (1f - S * (1f - mod));
			switch (sel + 1)
			{
			case 0:
				col.r = V;
				col.g = v1;
				col.b = v2;
				break;
			case 1:
				col.r = V;
				col.g = v3;
				col.b = v1;
				break;
			case 2:
				col.r = v2;
				col.g = V;
				col.b = v1;
				break;
			case 3:
				col.r = v1;
				col.g = V;
				col.b = v3;
				break;
			case 4:
				col.r = v1;
				col.g = v2;
				col.b = V;
				break;
			case 5:
				col.r = v3;
				col.g = v1;
				col.b = V;
				break;
			case 6:
				col.r = V;
				col.g = v1;
				col.b = v2;
				break;
			case 7:
				col.r = V;
				col.g = v3;
				col.b = v1;
				break;
			}
			col.r = Mathf.Clamp(col.r, 0f, 1f);
			col.g = Mathf.Clamp(col.g, 0f, 1f);
			col.b = Mathf.Clamp(col.b, 0f, 1f);
			return col;
		}
	}
}
