using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundclick : MonoBehaviour {

	public AudioSource source;
	public AudioClip click;
	//private Button button{get {return GetComponent<Button> ();}}
//	private AudioSource source{get {return GetComponent<AudioSource> ();}}



	// Use this for initialization
	void Start () {
		
	}

	public void PlaySound(){
		Debug.Log ("sound");
		source.PlayOneShot (click);
	
	}
	
	// Update is called once per frame

}
