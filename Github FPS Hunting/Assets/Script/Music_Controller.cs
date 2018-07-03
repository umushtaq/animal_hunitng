using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Music_Controller : MonoBehaviour {

	public Slider volume;
	public AudioSource music;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		music.volume=volume.value;
	}
}
