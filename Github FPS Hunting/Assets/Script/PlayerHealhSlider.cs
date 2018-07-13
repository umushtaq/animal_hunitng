using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealhSlider : MonoBehaviour {

	private float healthValue;
	private Slider healthSlider;
	// Use this for initialization
	void Start () {
		healthValue = FPSPlayer.instance.hitPoints;	
		healthSlider.value = healthValue;
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}

	public void SetHealth(float health)
	{
		healthSlider.value = health;
	}
}
