using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateLion : MonoBehaviour {

	public static instantiateLion instance;

	public GameObject LionPrefab;
	public Transform[] LionPosition;
	public Transform[][] Array;

	void Awake()
	{
		instance = this;
	}

	void Start(){
		FleshDie ();
	}

	public void FleshDie()
	{
		Invoke ("Lion",3f);
	}

	void Lion()
	{
		int value = Random.Range (0,3);
		Debug.Log ("Value "+value);
		Instantiate (LionPrefab,LionPosition[value].position,LionPosition[value].rotation);
	}


}
