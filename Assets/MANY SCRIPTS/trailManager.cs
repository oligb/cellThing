using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class trailManager : MonoBehaviour {

	// Use this for initialization
	public GameObject manager;
	public float startWidth;
	public float endWidth;
	public TrailRenderer trails;
	public int randoColor;
	public Values vals;
	void Start () {

		manager=GameObject.Find("Manager");
		trails=GetComponent<TrailRenderer>();
		randoColor=Random.Range(0,manager.GetComponent<Values>().colors.Count);
		vals= manager.GetComponent<Values>();
	}
	
	// Update is called once per frame
	void Update () {
		trails.startWidth=manager.GetComponent<Values>().startWidth;
		trails.endWidth=manager.GetComponent<Values>().endWidth;
		trails.materials[0].color=manager.GetComponent<Values>().colors[randoColor];
	}
}
