using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuttingTogether : MonoBehaviour {
	public GameObject[] grapesArray;
	public Text grapesText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		grapesArray = GameObject.FindGameObjectsWithTag ("Grape");
		grapesText.text = grapesArray.Length.ToString ();


		
	}
}
